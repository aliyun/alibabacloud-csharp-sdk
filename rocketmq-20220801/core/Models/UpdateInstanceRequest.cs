// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The access control information.</para>
        /// </summary>
        [NameInMap("aclInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestAclInfo AclInfo { get; set; }
        public class UpdateInstanceRequestAclInfo : TeaModel {
            /// <summary>
            /// <para>The authentication type of the instance.</para>
            /// </summary>
            [NameInMap("aclTypes")]
            [Validation(Required=false)]
            public List<string> AclTypes { get; set; }

            /// <summary>
            /// <para>Indicates whether password-free access is enabled for VPC connections under the intelligent identity recognition type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("defaultVpcAuthFree")]
            [Validation(Required=false)]
            public bool? DefaultVpcAuthFree { get; set; }

        }

        /// <summary>
        /// <para>The updated instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_instance</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The updated network information of the instance.</para>
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class UpdateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// <para>The public network information. This parameter is valid only when the public network access feature is enabled for the instance.</para>
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public UpdateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class UpdateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// <para>The public network access IP whitelist.</para>
                /// <list type="bullet">
                /// <item><description>If no IP whitelist is configured, all IP address ranges are allowed to access the ApsaraMQ for RocketMQ server over the public network by default.</description></item>
                /// <item><description>If an IP whitelist is configured, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ server over the public network.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                public List<string> IpWhitelist { get; set; }

            }

        }

        /// <summary>
        /// <para>The extension configurations of the instance.</para>
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestProductInfo ProductInfo { get; set; }
        public class UpdateInstanceRequestProductInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the adaptive elasticity capability. A value of true indicates enabled, and a value of false indicates shutdown.</para>
            /// </summary>
            [NameInMap("adaptiveElasticity")]
            [Validation(Required=false)]
            public bool? AdaptiveElasticity { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burstable elastic capacity beyond the specification.</para>
            /// <para>After the burstable elastic capacity is enabled, ApsaraMQ for RocketMQ allows the instance to exceed the TPS limit of the base specification within a certain range. The portion that exceeds the base specification incurs additional elastic specification fees. For more information about billing, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing fee</a>.</para>
            /// <remarks>
            /// <para>Only instances of specific specifications support the burstable elastic specification capability. For more information about supported instances, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance specifications</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            /// <summary>
            /// <para>The message retention period. Unit: hours.</para>
            /// <para>For the valid values, see <a href="https://help.aliyun.com/document_detail/440347.html">Limits</a> &gt; Resource Quotas &gt; Message retention period limit.</para>
            /// <para>The log broker in ApsaraMQ for RocketMQ is fully serverless and elastic. Fees are charged based on the actual storage space used. You can control the storage capacity of messages by adjusting the message retention period. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fee</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// <para>The ratio of messages sent to messages accepted.</para>
            /// <para>Valid values: [0.25, 1]</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the message trace feature.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;This parameter does not take effect. Regardless of whether this parameter is enabled, the instance supports the message trace feature by default.
            /// &lt;props=&quot;china&quot;&gt;This parameter takes effect only for Serverless instances. If the message trace feature is enabled, message trace fees are incurred. For more information about billing, see <a href="https://help.aliyun.com/document_detail/2586280.html">Serverless billing</a>.
            /// &lt;props=&quot;china&quot;&gt;For pay-as-you-go and subscription instances, this parameter does not take effect. The message trace feature is supported by default regardless of whether this parameter is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("traceOn")]
            [Validation(Required=false)]
            public bool? TraceOn { get; set; }

        }

        /// <summary>
        /// <para>The updated remarks for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
