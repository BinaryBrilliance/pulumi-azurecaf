// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace BinaryBrilliance.Azurecaf
{
    public static class GetEnvironmentVariable
    {
        public static Task<GetEnvironmentVariableResult> InvokeAsync(GetEnvironmentVariableArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetEnvironmentVariableResult>("azurecaf:index/getEnvironmentVariable:getEnvironmentVariable", args ?? new GetEnvironmentVariableArgs(), options.WithDefaults());

        public static Output<GetEnvironmentVariableResult> Invoke(GetEnvironmentVariableInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetEnvironmentVariableResult>("azurecaf:index/getEnvironmentVariable:getEnvironmentVariable", args ?? new GetEnvironmentVariableInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEnvironmentVariableArgs : global::Pulumi.InvokeArgs
    {
        [Input("failsIfEmpty")]
        public bool? FailsIfEmpty { get; set; }

        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetEnvironmentVariableArgs()
        {
        }
        public static new GetEnvironmentVariableArgs Empty => new GetEnvironmentVariableArgs();
    }

    public sealed class GetEnvironmentVariableInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("failsIfEmpty")]
        public Input<bool>? FailsIfEmpty { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetEnvironmentVariableInvokeArgs()
        {
        }
        public static new GetEnvironmentVariableInvokeArgs Empty => new GetEnvironmentVariableInvokeArgs();
    }


    [OutputType]
    public sealed class GetEnvironmentVariableResult
    {
        public readonly bool? FailsIfEmpty;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string Value;

        [OutputConstructor]
        private GetEnvironmentVariableResult(
            bool? failsIfEmpty,

            string id,

            string name,

            string value)
        {
            FailsIfEmpty = failsIfEmpty;
            Id = id;
            Name = name;
            Value = value;
        }
    }
}
