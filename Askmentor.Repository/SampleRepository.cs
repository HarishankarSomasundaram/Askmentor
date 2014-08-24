using Askmentor.Core.Repository;
using Askmentor.DataEntity.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askmentor.Repository
{
    public class SampleRepository : ISampleRepository
    {
        public int read(DataEntity.Sample.Sample name)
        {
            var newAnalysis = new Sample
            {
                Name = Sample.Name;
            };
            using (var ctx = new MirrorsEntities())
            {
                var analyses = ctx.Analyses;
                analyses.Add(newAnalysis);
                try
                {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var failure in ex.EntityValidationErrors)
                    {
                        sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                        foreach (var error in failure.ValidationErrors)
                        {
                            sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                            sb.AppendLine();
                        }
                    }

                    var logger = IoC.Resolve<ILogger>();

                    logger.LogFatal(sb.ToString(), ex);

                    throw new DbEntityValidationException(
                                "Entity Validation Failed - errors follow:\n" +
                                sb.ToString(), ex
                            ); // Add the original exception as the innerException

                }
                catch (DbUpdateException ex)
                {
                    var innerEx = ex.InnerException;

                    while (innerEx.InnerException != null)
                        innerEx = innerEx.InnerException;
                    var logger = IoC.Resolve<ILogger>();
                    logger.LogFatal(innerEx.Message, ex);
                    throw new DbUpdateException(innerEx.Message, ex);
                }

            }
            return newAnalysis.AnalysisID;
        }
    }
}
