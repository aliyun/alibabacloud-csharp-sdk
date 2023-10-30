// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AcceptOperationTicketRequest : TeaModel {
        /// <summary>
        /// The maximum number of logons allowed. Valid values:
        /// 
        /// *   0: The number of logons is unlimited. The O\&M engineer can log on to the specified asset for an unlimited number of times during the validity period.
        /// *   1: The O\&M engineer can log on to the specified asset only once during the validity period.
        /// 
        /// >  You can set this parameter only to 0 if you review an O\&M application on a database.
        /// </summary>
        [NameInMap("EffectCount")]
        [Validation(Required=false)]
        public string EffectCount { get; set; }

        /// <summary>
        /// The end time of the validity period. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EffectEndTime")]
        [Validation(Required=false)]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// The start time of the validity period. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EffectStartTime")]
        [Validation(Required=false)]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// The ID of the bastion host.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the O\&M application that you want to approve. You can call the ListOperationTickets operation to query the IDs of all O\&M applications that require review.
        /// </summary>
        [NameInMap("OperationTicketId")]
        [Validation(Required=false)]
        public string OperationTicketId { get; set; }

        /// <summary>
        /// The region ID of the bastion host.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
