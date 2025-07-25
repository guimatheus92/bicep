// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Bicep.Core.UnitTests.Utils;
using Bicep.IO.Abstraction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bicep.Core.UnitTests.Features;

public record FeatureProviderOverrides(
    IDirectoryHandle? CacheRootDirectory = null,
    bool? RegistryEnabled = default,
    bool? SymbolicNameCodegenEnabled = default,
    bool? AdvancedListComprehensionEnabled = default,
    bool? ResourceTypedParamsAndOutputsEnabled = default,
    bool? SourceMappingEnabled = default,
    bool? LegacyFormatterEnabled = default,
    bool? TestFrameworkEnabled = default,
    bool? AssertsEnabled = default,
    bool? WaitAndRetryEnabled = default,
    bool? LocalDeployEnabled = default,
    bool? ResourceInfoCodegenEnabled = default,
    bool? ExtendableParamFilesEnabled = default,
    string? AssemblyVersion = BicepTestConstants.DevAssemblyFileVersion,
    bool? ModuleExtensionConfigsEnabled = default,
    bool? DesiredStateConfigurationEnabled = default,
    bool? OnlyIfNotExistsEnabled = default,
    bool? ModuleIdentityEnabled = default)
{
    public FeatureProviderOverrides(
        TestContext testContext,
        bool? RegistryEnabled = default,
        bool? SymbolicNameCodegenEnabled = default,
        bool? AdvancedListComprehensionEnabled = default,
        bool? ResourceTypedParamsAndOutputsEnabled = default,
        bool? SourceMappingEnabled = default,
        bool? LegacyFormatterEnabled = default,
        bool? TestFrameworkEnabled = default,
        bool? AssertsEnabled = default,
        bool? WaitAndRetryEnabled = default,
        bool? LocalDeployEnabled = default,
        bool? ResourceInfoCodegenEnabled = default,
        bool? ExtendableParamFilesEnabled = default,
        string? AssemblyVersion = BicepTestConstants.DevAssemblyFileVersion,
        bool? ModuleExtensionConfigsEnabled = default,
        bool? DesiredStateConfigurationEnabled = default,
        bool? OnlyIfNotExistsEnabled = default,
        bool? ModuleIdentityEnabled = default
    ) : this(
        FileHelper.GetCacheRootDirectory(testContext),
        RegistryEnabled,
        SymbolicNameCodegenEnabled,
        AdvancedListComprehensionEnabled,
        ResourceTypedParamsAndOutputsEnabled,
        SourceMappingEnabled,
        LegacyFormatterEnabled,
        TestFrameworkEnabled,
        AssertsEnabled,
        WaitAndRetryEnabled,
        LocalDeployEnabled,
        ResourceInfoCodegenEnabled,
        ExtendableParamFilesEnabled,
        AssemblyVersion,
        ModuleExtensionConfigsEnabled,
        DesiredStateConfigurationEnabled,
        OnlyIfNotExistsEnabled,
        ModuleIdentityEnabled)
    { }
}
