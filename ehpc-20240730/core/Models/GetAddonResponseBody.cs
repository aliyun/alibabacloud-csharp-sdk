// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetAddonResponseBody : TeaModel {
        [NameInMap("Addon")]
        [Validation(Required=false)]
        public GetAddonResponseBodyAddon Addon { get; set; }
        public class GetAddonResponseBodyAddon : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("AddonId")]
            [Validation(Required=false)]
            public string AddonId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("InstallTime")]
            [Validation(Required=false)]
            public string InstallTime { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourcesSpec")]
            [Validation(Required=false)]
            public GetAddonResponseBodyAddonResourcesSpec ResourcesSpec { get; set; }
            public class GetAddonResponseBodyAddonResourcesSpec : TeaModel {
                [NameInMap("EcsResources")]
                [Validation(Required=false)]
                public List<AddonNodeTemplate> EcsResources { get; set; }

                [NameInMap("EipResource")]
                [Validation(Required=false)]
                public GetAddonResponseBodyAddonResourcesSpecEipResource EipResource { get; set; }
                public class GetAddonResponseBodyAddonResourcesSpecEipResource : TeaModel {
                    [NameInMap("AutoCreate")]
                    [Validation(Required=false)]
                    public bool? AutoCreate { get; set; }

                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public string Bandwidth { get; set; }

                    [NameInMap("EipAddress")]
                    [Validation(Required=false)]
                    public string EipAddress { get; set; }

                    [NameInMap("EipInstanceId")]
                    [Validation(Required=false)]
                    public string EipInstanceId { get; set; }

                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                }

            }

            [NameInMap("ServicesSpec")]
            [Validation(Required=false)]
            public List<GetAddonResponseBodyAddonServicesSpec> ServicesSpec { get; set; }
            public class GetAddonResponseBodyAddonServicesSpec : TeaModel {
                [NameInMap("InputParams")]
                [Validation(Required=false)]
                public List<GetAddonResponseBodyAddonServicesSpecInputParams> InputParams { get; set; }
                public class GetAddonResponseBodyAddonServicesSpecInputParams : TeaModel {
                    [NameInMap("HelpText")]
                    [Validation(Required=false)]
                    public string HelpText { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("NetworkACL")]
                [Validation(Required=false)]
                public List<GetAddonResponseBodyAddonServicesSpecNetworkACL> NetworkACL { get; set; }
                public class GetAddonResponseBodyAddonServicesSpecNetworkACL : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("IpProtocol")]
                    [Validation(Required=false)]
                    public string IpProtocol { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public float? Port { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                }

                [NameInMap("ServiceAccessType")]
                [Validation(Required=false)]
                public string ServiceAccessType { get; set; }

                [NameInMap("ServiceAccessUrl")]
                [Validation(Required=false)]
                public string ServiceAccessUrl { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
