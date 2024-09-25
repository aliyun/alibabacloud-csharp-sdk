// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The access control list for the instance.</para>
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
            /// <para>Indicates whether the authentication-free in VPCs feature is enabled.
            /// Indicates whether the authentication-free in VPCs feature is enabled.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("defaultVpcAuthFree")]
            [Validation(Required=false)]
            public bool? DefaultVpcAuthFree { get; set; }

        }

        /// <summary>
        /// <para>The updated name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_instance</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The updated network information about the instance.</para>
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class UpdateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// <para>The information about the Internet over which the instance is accessed. This parameter takes effect only if the Internet access feature is enabled for the instance.</para>
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public UpdateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class UpdateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// <para>The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</para>
                /// <list type="bullet">
                /// <item><description>If you do not configure an IP address whitelist, all CIDR blocks are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                /// <item><description>If you configure an IP address whitelist, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                public List<string> IpWhitelist { get; set; }

            }

        }

        /// <summary>
        /// <para>Additional configurations of the instance.</para>
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestProductInfo ProductInfo { get; set; }
        public class UpdateInstanceRequestProductInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the elastic transactions per second (TPS) feature for the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>After you enable the elastic TPS feature for an ApsaraMQ for RocketMQ instance, you can use a specific number of TPS that exceeds the specification limit. You are charged for using the elastic TPS feature. For more information, see <a href="https://help.aliyun.com/document_detail/427237.html">Computing fees</a>.</para>
            /// <remarks>
            /// <para> The elastic TPS feature is supported only by specific instance editions. For more information, see <a href="https://help.aliyun.com/document_detail/444715.html">Instance editions</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            /// <summary>
            /// <para>The retention period of messages. Unit: hours.</para>
            /// <para>For information about the valid values of this parameter, see the &quot;Limits on resource quotas&quot; section of the <a href="https://help.aliyun.com/document_detail/440347.html">Limits</a> topic.</para>
            /// <para>ApsaraMQ for RocketMQ supports serverless scaling of message storage. You are charged storage fees based on your actual storage usage. You can change the retention period of messages to manage storage capacity. For more information, see <a href="https://help.aliyun.com/document_detail/427238.html">Storage fees</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// <para>The ratio of the number of messages that you can send to the number of messages that you can receive on the instance.</para>
            /// <para>Value values: 0.25 to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the message trace feature.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>This parameter is not in use. By default, the message trace feature is enabled for ApsaraMQ for RocketMQ instances, regardless of whether this parameter is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("traceOn")]
            [Validation(Required=false)]
            public bool? TraceOn { get; set; }

        }

        /// <summary>
        /// <para>The updated description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the remark for test.</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
