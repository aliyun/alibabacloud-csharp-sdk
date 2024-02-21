// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// The updated name of the instance.
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The updated network information about the instance.
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class UpdateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// The information about the Internet over which the instance is accessed. This parameter takes effect only if the Internet access feature is enabled for the instance.
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public UpdateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class UpdateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// The whitelist that includes the IP addresses that are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// 
                /// *   If you do not configure an IP address whitelist, all CIDR blocks are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// *   If you configure an IP address whitelist, only the IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                public List<string> IpWhitelist { get; set; }

            }

        }

        /// <summary>
        /// Additional configurations of the instance.
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestProductInfo ProductInfo { get; set; }
        public class UpdateInstanceRequestProductInfo : TeaModel {
            /// <summary>
            /// Specifies whether to enable the elastic transactions per second (TPS) feature for the instance.
            /// 
            /// Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// After you enable the elastic TPS feature for an ApsaraMQ for RocketMQ instance, you can use a specific number of TPS that exceeds the specification limit. You are charged for using the elastic TPS feature. For more information, see [Computing fees](~~427237~~).
            /// 
            /// >  The elastic TPS feature is supported only by specific instance editions. For more information, see [Instance editions](~~444715~~).
            /// </summary>
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            /// <summary>
            /// The retention period of messages. Unit: hours.
            /// 
            /// For information about the valid values of this parameter, see the "Limits on resource quotas" section of the [Limits](~~440347~~) topic.
            /// 
            /// ApsaraMQ for RocketMQ supports serverless scaling of message storage. You are charged storage fees based on your actual storage usage. You can change the retention period of messages to manage storage capacity. For more information, see [Storage fees](~~427238~~).
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// The ratio of the number of messages that you can send to the number of messages that you can receive on the instance.
            /// 
            /// Value values: 0.25 to 1.
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

            /// <summary>
            /// Specifies whether to enable the message trace feature.
            /// 
            /// *   true
            /// *   false
            /// 
            /// This parameter is not in use. By default, the message trace feature is enabled for ApsaraMQ for RocketMQ instances, regardless of whether this parameter is configured.
            /// </summary>
            [NameInMap("traceOn")]
            [Validation(Required=false)]
            public bool? TraceOn { get; set; }

        }

        /// <summary>
        /// The updated description of the instance.
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
