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
    public static class GetName
    {
        public static Task<GetNameResult> InvokeAsync(GetNameArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNameResult>("azurecaf:index/getName:getName", args ?? new GetNameArgs(), options.WithDefaults());

        public static Output<GetNameResult> Invoke(GetNameInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNameResult>("azurecaf:index/getName:getName", args ?? new GetNameInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNameArgs : global::Pulumi.InvokeArgs
    {
        [Input("cleanInput")]
        public bool? CleanInput { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("passthrough")]
        public bool? Passthrough { get; set; }

        [Input("prefixes")]
        private List<string>? _prefixes;
        public List<string> Prefixes
        {
            get => _prefixes ?? (_prefixes = new List<string>());
            set => _prefixes = value;
        }

        [Input("randomLength")]
        public int? RandomLength { get; set; }

        [Input("randomSeed")]
        public int? RandomSeed { get; set; }

        [Input("resourceType")]
        public string? ResourceType { get; set; }

        [Input("separator")]
        public string? Separator { get; set; }

        [Input("suffixes")]
        private List<string>? _suffixes;
        public List<string> Suffixes
        {
            get => _suffixes ?? (_suffixes = new List<string>());
            set => _suffixes = value;
        }

        [Input("useSlug")]
        public bool? UseSlug { get; set; }

        public GetNameArgs()
        {
        }
        public static new GetNameArgs Empty => new GetNameArgs();
    }

    public sealed class GetNameInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("cleanInput")]
        public Input<bool>? CleanInput { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("passthrough")]
        public Input<bool>? Passthrough { get; set; }

        [Input("prefixes")]
        private InputList<string>? _prefixes;
        public InputList<string> Prefixes
        {
            get => _prefixes ?? (_prefixes = new InputList<string>());
            set => _prefixes = value;
        }

        [Input("randomLength")]
        public Input<int>? RandomLength { get; set; }

        [Input("randomSeed")]
        public Input<int>? RandomSeed { get; set; }

        [Input("resourceType")]
        public Input<string>? ResourceType { get; set; }

        [Input("separator")]
        public Input<string>? Separator { get; set; }

        [Input("suffixes")]
        private InputList<string>? _suffixes;
        public InputList<string> Suffixes
        {
            get => _suffixes ?? (_suffixes = new InputList<string>());
            set => _suffixes = value;
        }

        [Input("useSlug")]
        public Input<bool>? UseSlug { get; set; }

        public GetNameInvokeArgs()
        {
        }
        public static new GetNameInvokeArgs Empty => new GetNameInvokeArgs();
    }


    [OutputType]
    public sealed class GetNameResult
    {
        public readonly bool? CleanInput;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly bool? Passthrough;
        public readonly ImmutableArray<string> Prefixes;
        public readonly int? RandomLength;
        public readonly int? RandomSeed;
        public readonly string? ResourceType;
        public readonly string Result;
        public readonly string? Separator;
        public readonly ImmutableArray<string> Suffixes;
        public readonly bool? UseSlug;

        [OutputConstructor]
        private GetNameResult(
            bool? cleanInput,

            string id,

            string? name,

            bool? passthrough,

            ImmutableArray<string> prefixes,

            int? randomLength,

            int? randomSeed,

            string? resourceType,

            string result,

            string? separator,

            ImmutableArray<string> suffixes,

            bool? useSlug)
        {
            CleanInput = cleanInput;
            Id = id;
            Name = name;
            Passthrough = passthrough;
            Prefixes = prefixes;
            RandomLength = randomLength;
            RandomSeed = randomSeed;
            ResourceType = resourceType;
            Result = result;
            Separator = separator;
            Suffixes = suffixes;
            UseSlug = useSlug;
        }
    }
}
