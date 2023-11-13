// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainOverviewRequest : TeaModel {
        /// <summary>
        /// The domain name of the website that you want to query. If you leave this parameter unspecified, the statistics on all domain names are queried.
        /// 
        /// > The domain name must be added to Anti-DDoS Pro or Anti-DDoS Premium. You can call the [DescribeDomains](~~91724~~) operation to query all the domain names that are added to Anti-DDoS Pro or Anti-DDoS Premium.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you leave this parameter unspecified, the current system time is used as the end time.
        /// 
        /// > This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// 
        /// For more information about resource groups, see [Create a resource group](~~94485~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// > This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
