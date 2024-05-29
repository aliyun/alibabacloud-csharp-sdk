// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigLayer4RealLimitRequest : TeaModel {
        /// <summary>
        /// The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies the threshold of the clean bandwidth. Valid values: 0 to 15360. The value 0 indicates that rate limiting is never triggered. Unit: Mbit/s
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LimitValue")]
        [Validation(Required=false)]
        public long? LimitValue { get; set; }

    }

}
