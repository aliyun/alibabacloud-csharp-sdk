// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceResponseBody : TeaModel {
        [NameInMap("AdditionalIngresses")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceResponseBodyAdditionalIngresses> AdditionalIngresses { get; set; }
        public class DescribeRenderingInstanceResponseBodyAdditionalIngresses : TeaModel {
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("PortMappings")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceResponseBodyAdditionalIngressesPortMappings> PortMappings { get; set; }
            public class DescribeRenderingInstanceResponseBodyAdditionalIngressesPortMappings : TeaModel {
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

            }

        }

        [NameInMap("ConfigInfo")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyConfigInfo ConfigInfo { get; set; }
        public class DescribeRenderingInstanceResponseBodyConfigInfo : TeaModel {
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceResponseBodyConfigInfoConfiguration> Configuration { get; set; }
            public class DescribeRenderingInstanceResponseBodyConfigInfoConfiguration : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<DescribeRenderingInstanceResponseBodyConfigInfoConfigurationAttributes> Attributes { get; set; }
                public class DescribeRenderingInstanceResponseBodyConfigInfoConfigurationAttributes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>lon</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>location</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

            [NameInMap("NetworkConfig")]
            [Validation(Required=false)]
            public DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig NetworkConfig { get; set; }
            public class DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("BandwidthStatus")]
                [Validation(Required=false)]
                public string BandwidthStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxEgressBandwidth")]
                [Validation(Required=false)]
                public int? MaxEgressBandwidth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxIngressBandwidth")]
                [Validation(Required=false)]
                public int? MaxIngressBandwidth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-08-17T09:54:35Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-05-07T02:27:06Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("EgressIp")]
        [Validation(Required=false)]
        public string EgressIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-xxx.ecr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceResponseBodyPortMappings> PortMappings { get; set; }
        public class DescribeRenderingInstanceResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        [NameInMap("RenderingSpec")]
        [Validation(Required=false)]
        public string RenderingSpec { get; set; }

        [NameInMap("RenderingStatus")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyRenderingStatus RenderingStatus { get; set; }
        public class DescribeRenderingInstanceResponseBodyRenderingStatus : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MigrateLocalData</para>
            /// </summary>
            [NameInMap("LatestAction")]
            [Validation(Required=false)]
            public string LatestAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

        [NameInMap("SystemInfo")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodySystemInfo SystemInfo { get; set; }
        public class DescribeRenderingInstanceResponseBodySystemInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public int? Frequency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1920*1080</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

        }

    }

}
