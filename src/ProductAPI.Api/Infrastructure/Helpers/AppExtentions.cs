namespace ProductAPI.Api.Infrastructure.Helpers
{
    public static class AppExtentions
    {
        public static string ToModelStateErrorString(this Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary modelState)
        {
            if (modelState is null || modelState.Count == 0)
            {
                return "Model is Empty";
            }
            return string.Join("\n", modelState.Keys.Where(x => modelState[x].Errors.Count > 0).Select(
                x => string.Join(":", x, string.Join("|", modelState[x].Errors.Select(y => y.ErrorMessage)))
                ));



        }
    }
}
