// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListLogstashResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing method of the instance. Supported: prepaid (subscription) and postpaid (pay-as-you-go).</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListLogstashResponseBodyHeaders Headers { get; set; }
        public class ListLogstashResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The number of data nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>Detailed information about the matching instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC442F2F-5068-4434-AA21-E78947A9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the VPC.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLogstashResponseBodyResult> Result { get; set; }
        public class ListLogstashResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configuration information of the data node.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLogstashResponseBodyResultTags> Tags { get; set; }
            public class ListLogstashResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The disk size of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The instance type of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-13T03:58:07.253Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The time when the instance was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ls-cn-abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The tag value of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ls-cn-n6w1o5jq****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The network type. Currently, only Virtual Private Cloud (VPC) is supported.</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public ListLogstashResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class ListLogstashResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-abc</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-*</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-def</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The state of the instance. Valid values: Normal, Active, Inactive, and Invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>Specifies whether to use disk encryption. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enables the concurrent query feature for queries other than aggregate queries.</description></item>
            /// <item><description>false: Disables the concurrent query feature for queries other than aggregate queries.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public ListLogstashResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class ListLogstashResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <para>The network configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <para>The zone where the cluster resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The type of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logstash.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The version of the instance. Currently, only 6.7.0_with_X-Pack and 7.4.0_with_X-Pack are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag of the instance. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-18T10:10:04.484Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The tag key of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.7.0_with_X-Pack</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
