// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListLogstashResponseBody : TeaModel {
        /// <summary>
        /// Details of the request header.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListLogstashResponseBodyHeaders Headers { get; set; }
        public class ListLogstashResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Detailed information about the matching instances.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLogstashResponseBodyResult> Result { get; set; }
        public class ListLogstashResponseBodyResult : TeaModel {
            /// <summary>
            /// The tag of the instance. Valid values:
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLogstashResponseBodyResultTags> Tags { get; set; }
            public class ListLogstashResponseBodyResultTags : TeaModel {
                /// <summary>
                /// The tag key of the cloud disk.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the cloud disk.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// The name of the VPC.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The network configurations.
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public ListLogstashResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class ListLogstashResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// The network type. Currently, only Virtual Private Cloud (VPC) is supported.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone where the cluster resides.
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// The number of data nodes.
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// The configuration information of the data node.
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public ListLogstashResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class ListLogstashResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// The disk size of the node.
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// Specifies whether to use disk encryption. Valid values:
                /// 
                /// *   true: Enables the concurrent query feature for queries other than aggregate queries.
                /// *   false: Disables the concurrent query feature for queries other than aggregate queries.
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// The type of the disk.
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The instance type of the ECS instance.
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The billing method of the instance. Supported: prepaid (subscription) and postpaid (pay-as-you-go).
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The state of the instance. Valid values: Normal, Active, Inactive, and Invalid.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the instance was last updated.
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// The version of the instance. Currently, only 6.7.0\_with_X-Pack and 7.4.0\_with_X-Pack are supported.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
