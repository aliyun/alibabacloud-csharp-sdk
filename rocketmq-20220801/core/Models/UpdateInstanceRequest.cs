// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// The new name of the instance.
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The new network information about the instance.
        /// </summary>
        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class UpdateInstanceRequestNetworkInfo : TeaModel {
            /// <summary>
            /// The Internet information about the instance. This parameter takes effect only when the Internet access feature is enabled for the instance.
            /// </summary>
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public UpdateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class UpdateInstanceRequestNetworkInfoInternetInfo : TeaModel {
                /// <summary>
                /// The IP address whitelist that allows access to the instance over the Internet.
                /// 
                /// *   If you do not configure an IP address whitelist, all IP addresses are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// *   If you configure an IP address whitelist, only IP addresses in the whitelist are allowed to access the ApsaraMQ for RocketMQ broker over the Internet.
                /// </summary>
                [NameInMap("ipWhitelist")]
                [Validation(Required=false)]
                public List<string> IpWhitelist { get; set; }

            }

        }

        /// <summary>
        /// The extended configurations of the instance.
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public UpdateInstanceRequestProductInfo ProductInfo { get; set; }
        public class UpdateInstanceRequestProductInfo : TeaModel {
            /// <summary>
            /// Specifies whether to enable burst scaling for the instance.
            /// 
            /// Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// After you enable burst scaling, the system allows the actual messaging transactions per second (TPS) of the ApsaraMQ for RocketMQ instance to exceed the upper limit of the basic computing specification. You are charged for the extra TPS. For more information, see [Computing fee](~~427237~~).
            /// 
            /// > Only specific types of instances support burst scaling. For more information, see [Instance specifications](~~444715~~).
            /// </summary>
            [NameInMap("autoScaling")]
            [Validation(Required=false)]
            public bool? AutoScaling { get; set; }

            /// <summary>
            /// The retention period of messages. Unit: hours.
            /// 
            /// For more information about the valid values, see the "Limits on resource quotas" section of the [Usage limits](~~440347~~) topic.
            /// 
            /// The storage of ApsaraMQ for RocketMQ messages is in serverless scaling mode. You are charged based on the actual used storage. You can adjust the storage retention period to reduce storage usage and costs. For more information, see [Storage fees](~~427238~~).
            /// </summary>
            [NameInMap("messageRetentionTime")]
            [Validation(Required=false)]
            public int? MessageRetentionTime { get; set; }

            /// <summary>
            /// The ratio of the number of messages that you can send to the number of messages that you can receive in the instance.
            /// 
            /// Value values: 0.25 to 1.
            /// </summary>
            [NameInMap("sendReceiveRatio")]
            [Validation(Required=false)]
            public float? SendReceiveRatio { get; set; }

            [NameInMap("traceOn")]
            [Validation(Required=false)]
            public bool? TraceOn { get; set; }

        }

        /// <summary>
        /// The new remarks on the instance.
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
