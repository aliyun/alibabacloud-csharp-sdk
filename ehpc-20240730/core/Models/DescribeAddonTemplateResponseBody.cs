// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class DescribeAddonTemplateResponseBody : TeaModel {
        [NameInMap("Addon")]
        [Validation(Required=false)]
        public DescribeAddonTemplateResponseBodyAddon Addon { get; set; }
        public class DescribeAddonTemplateResponseBodyAddon : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("LastUpdate")]
            [Validation(Required=false)]
            public string LastUpdate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourcesSpec")]
            [Validation(Required=false)]
            public DescribeAddonTemplateResponseBodyAddonResourcesSpec ResourcesSpec { get; set; }
            public class DescribeAddonTemplateResponseBodyAddonResourcesSpec : TeaModel {
                [NameInMap("EcsResources")]
                [Validation(Required=false)]
                public List<AddonNodeTemplate> EcsResources { get; set; }

                [NameInMap("EipResource")]
                [Validation(Required=false)]
                public DescribeAddonTemplateResponseBodyAddonResourcesSpecEipResource EipResource { get; set; }
                public class DescribeAddonTemplateResponseBodyAddonResourcesSpecEipResource : TeaModel {
                    [NameInMap("AutoCreate")]
                    [Validation(Required=false)]
                    public bool? AutoCreate { get; set; }

                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public string Bandwidth { get; set; }

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
            public List<DescribeAddonTemplateResponseBodyAddonServicesSpec> ServicesSpec { get; set; }
            public class DescribeAddonTemplateResponseBodyAddonServicesSpec : TeaModel {
                [NameInMap("InputParams")]
                [Validation(Required=false)]
                public List<DescribeAddonTemplateResponseBodyAddonServicesSpecInputParams> InputParams { get; set; }
                public class DescribeAddonTemplateResponseBodyAddonServicesSpecInputParams : TeaModel {
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
                public List<DescribeAddonTemplateResponseBodyAddonServicesSpecNetworkACL> NetworkACL { get; set; }
                public class DescribeAddonTemplateResponseBodyAddonServicesSpecNetworkACL : TeaModel {
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
