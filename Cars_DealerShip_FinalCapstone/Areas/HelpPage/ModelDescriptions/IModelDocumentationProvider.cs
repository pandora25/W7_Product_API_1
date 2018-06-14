using System;
using System.Reflection;

namespace Cars_DealerShip_FinalCapstone.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}