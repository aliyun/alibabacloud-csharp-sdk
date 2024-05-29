// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcListCountRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the **DescribeInstanceIds** operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The mode of how an IP address is added to the whitelist or blacklist. Valid values:
        /// 
        /// *   **manual**: manually added
        /// *   **auto**: automatically added
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

    }

}
