// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceResponseBody : TeaModel {
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
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

            [NameInMap("NetworkConfig")]
            [Validation(Required=false)]
            public DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig NetworkConfig { get; set; }
            public class DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig : TeaModel {
                [NameInMap("BandwidthStatus")]
                [Validation(Required=false)]
                public string BandwidthStatus { get; set; }

                [NameInMap("MaxEgressBandwidth")]
                [Validation(Required=false)]
                public int? MaxEgressBandwidth { get; set; }

                [NameInMap("MaxIngressBandwidth")]
                [Validation(Required=false)]
                public int? MaxIngressBandwidth { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceResponseBodyPortMappings> PortMappings { get; set; }
        public class DescribeRenderingInstanceResponseBodyPortMappings : TeaModel {
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        [NameInMap("RenderingStatus")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyRenderingStatus RenderingStatus { get; set; }
        public class DescribeRenderingInstanceResponseBodyRenderingStatus : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LatestAction")]
            [Validation(Required=false)]
            public string LatestAction { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemInfo")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodySystemInfo SystemInfo { get; set; }
        public class DescribeRenderingInstanceResponseBodySystemInfo : TeaModel {
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public int? Frequency { get; set; }

            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

        }

    }

}
