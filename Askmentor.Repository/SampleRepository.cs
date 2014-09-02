//using Askmentor.Core;
//using Askmentor.Core.Repository;
//using Askmentor.DataEntity.Sample;
//using Askmentor.Infra;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity.Infrastructure;
//using System.Data.Entity.Validation;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Askmentor.Repository
//{
//    public class SampleRepository : ISampleRepository
//    {
//        public int read(DataEntity.Sample.Sample MentorObj)
//        {
//            var newData = new Sample
//            {
//                Name = MentorObj.Name
//            };
//            using (var ctx = new AskmentorStagingEntities())
//            {
//                var analyses = ctx.Mentees_Tbl;
//                analyses.Add(newData);
//                try
//                {
//                    ctx.SaveChanges();
//                }
//                catch (DbEntityValidationException ex)
//                {
//                    StringBuilder sb = new StringBuilder();
//                    foreach (var failure in ex.EntityValidationErrors)
//                    {
//                        sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
//                        foreach (var error in failure.ValidationErrors)
//                        {
//                            sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
//                            sb.AppendLine();
//                        }
//                    }

//                    var logger = IoC.Resolve<ILogger>();

//                    logger.LogFatal(sb.ToString(), ex);

//                    throw new DbEntityValidationException(
//                                "Entity Validation Failed - errors follow:\n" +
//                                sb.ToString(), ex
//                            ); // Add the original exception as the innerException

//                }
//                catch (DbUpdateException ex)
//                {
//                    var innerEx = ex.InnerException;

//                    while (innerEx.InnerException != null)
//                        innerEx = innerEx.InnerException;
//                    var logger = IoC.Resolve<ILogger>();
//                    logger.LogFatal(innerEx.Message, ex);
//                    throw new DbUpdateException(innerEx.Message, ex);
//                }

//            }
//            return newAnalysis.AnalysisID;
//        }
//    }
//}
