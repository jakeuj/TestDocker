using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestProj;

[Dependency(ReplaceServices = true)]
public class TestProjBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestProj";
}
