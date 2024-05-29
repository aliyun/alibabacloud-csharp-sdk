// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyElasticBizBandWidthRequest : TeaModel {
        /// <summary>
        /// The burstable clean bandwidth. Unit: Mbit/s. The burstable clean bandwidth cannot exceed nine times the clean bandwidth of your Anti-DDoS Pro or Anti-DDoS Premium instance, and the sum of the clean bandwidth and the burstable clean bandwidth cannot exceed the maximum clean bandwidth that is supported by your instance. The value 0 indicates that the burstable clean bandwidth feature is disabled. You can disable the burstable clean bandwidth feature once a month.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ElasticBizBandwidth")]
        [Validation(Required=false)]
        public int? ElasticBizBandwidth { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The metering method of the burstable clean bandwidth feature. Valid values:
        /// 
        /// *   **month**: the metering method of monthly 95th percentile
        /// *   **day**: the metering method of daily 95th percentile
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
