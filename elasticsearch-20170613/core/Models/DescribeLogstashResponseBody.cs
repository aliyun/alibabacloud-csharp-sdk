// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeLogstashResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed information about the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C9334241-4837-46C2-B24B-9BDC517318DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the instance.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeLogstashResponseBodyResult Result { get; set; }
        public class DescribeLogstashResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configuration information of the node.</para>
            /// </summary>
            [NameInMap("ExtendConfigs")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ExtendConfigs { get; set; }

            /// <summary>
            /// <para>The number of data nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzvowej3i****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The key of the tag.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultTags> Tags { get; set; }
            public class DescribeLogstashResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The information about the zones.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The status of the zone. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ISOLATION: offline</description></item>
            /// <item><description>NORMAL</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ZoneInfos")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultZoneInfos> ZoneInfos { get; set; }
            public class DescribeLogstashResponseBodyResultZoneInfos : TeaModel {
                /// <summary>
                /// <para>The zone ID of the new instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The configuration of cluster extension parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>prepaid: subscription</description></item>
            /// <item><description>postpaid: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;slowlog.threshold.warn&quot;: &quot;2s&quot;,&quot;slowlog.threshold.info&quot;: &quot;1s&quot;,&quot;slowlog.threshold.debug&quot;: &quot;500ms&quot;,&quot;slowlog.threshold.trace&quot;: &quot;100ms&quot; }</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, object> Config { get; set; }

            /// <summary>
            /// <para>The state of the instance. Four states are supported:</para>
            /// <list type="bullet">
            /// <item><description>Normal: active</description></item>
            /// <item><description>Active: activating</description></item>
            /// <item><description>Freeze: inactive</description></item>
            /// <item><description>Invalid: invalid</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-06T14:12:03.672Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ls-cn-abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the node resides.</para>
            /// </summary>
            [NameInMap("endpointList")]
            [Validation(Required=false)]
            public List<DescribeLogstashResponseBodyResultEndpointList> EndpointList { get; set; }
            public class DescribeLogstashResponseBodyResultEndpointList : TeaModel {
                /// <summary>
                /// <para>The tags added to the ALB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>172.16.**.**</c></para>
                /// </summary>
                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9600</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The access information of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ls-cn-abc</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public DescribeLogstashResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class DescribeLogstashResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the vSwitch to which the instance is connected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The zone where the cluster resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp16k1dvzxtmagcva****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values: Currently, only Virtual Private Cloud (VPC) are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-*</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-bp1k4ec6s7sjdbudw****</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The specifications of the node.</para>
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public DescribeLogstashResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class DescribeLogstashResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <para>Whether to use disk encryption:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The disk type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("diskEncryption")]
                [Validation(Required=false)]
                public bool? DiskEncryption { get; set; }

                /// <summary>
                /// <para>The network configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The disk size of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.sn1ne.large</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the elastic container instances belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The edition of the dedicated KMS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-06T14:22:36.850Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.4.0_with_X-Pack</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The time when the instance was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp16k1dvzxtmagcva****</para>
            /// </summary>
            [NameInMap("vpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

        }

    }

}
