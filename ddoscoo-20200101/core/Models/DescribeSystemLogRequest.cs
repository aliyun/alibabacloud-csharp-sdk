// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSystemLogRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The bills of the burstable clean bandwidth that are issued before this point in time are queried. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The IP address of the instance.
        /// 
        /// > You can call the [DescribeInstanceDetails](~~91490~~) operation to query the IP addresses of all instances.
        /// </summary>
        [NameInMap("EntityObject")]
        [Validation(Required=false)]
        public string EntityObject { get; set; }

        /// <summary>
        /// The type of the system log. Set the value to **20**, which indicates the billing logs for the burstable clean bandwidth.
        /// 
        /// > You must specify this parameter. Otherwise, the call fails.
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public int? EntityType { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The bills of the burstable clean bandwidth that are issued after this point in time are queried. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
