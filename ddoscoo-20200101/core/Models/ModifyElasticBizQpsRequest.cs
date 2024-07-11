// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyElasticBizQpsRequest : TeaModel {
        /// <summary>
        /// The ID of the Anti-DDoS Proxy instance.
        /// 
        /// >  You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The metering method for the burstable QPS. Valid values:
        /// 
        /// *   **month**: monthly 95th percentile
        /// *   **day**: daily 95th percentile QPS
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The burstable QPS value.
        /// 
        /// >  The default value is 300,000 for the Chinese mainland and 150,000 for regions outside the Chinese mainland.
        /// </summary>
        [NameInMap("OpsElasticQps")]
        [Validation(Required=false)]
        public long? OpsElasticQps { get; set; }

    }

}
