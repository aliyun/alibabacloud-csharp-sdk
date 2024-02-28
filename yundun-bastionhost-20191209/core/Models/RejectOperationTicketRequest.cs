// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class RejectOperationTicketRequest : TeaModel {
        /// <summary>
        /// The ID of the bastion host.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the O\&M application that you want to reject. You can call the ListOperationTickets operation to query the IDs of all O\&M applications that require review.
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
