// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeUdpReflectRequest : TeaModel {
        /// <summary>
        /// The ID of the instance to query.
        /// 
        /// > You can call the [DescribeInstanceIds](~~157459~~) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the instance. Valid values:
        /// 
        /// *   **cn-hangzhou**: Chinese mainland, which indicates an Anti-DDoS Pro instance. This is the default value.
        /// *   **ap-southeast-1**: outside the Chinese mainland, which indicates an Anti-DDoS Premium instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
