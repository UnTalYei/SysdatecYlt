using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Sysdatec.PruebaTecnica.Application.Features;

namespace Sysdatec.PruebaTecnica.Application.Exceptions
{
    public class ExceptionManager : IExceptionFilter
    {
        public ExceptionManager()
        {
        }
        public void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(ResponseApiService.Response(StatusCodes.Status500InternalServerError, context.Exception.Message, null));
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            //var metric = new InsertApplicationInsightsModel(
            //    ApplicationInsightsConstants.METRIC_TYPE_ERROR,
            //    context.Exception.Message,
            //    context.Exception.ToString());
            //_insertApplicationInsightsService.Execute(metric);
        }
    }
}
