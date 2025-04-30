using Microsoft.CodeAnalysis;

namespace Mathica.CodeAnalysis.Generators.Localization;

[Generator(LanguageNames.CSharp)]
public class LocalizationGenerator : IIncrementalGenerator {
    void IIncrementalGenerator.Initialize(
        IncrementalGeneratorInitializationContext context) {

    }
}