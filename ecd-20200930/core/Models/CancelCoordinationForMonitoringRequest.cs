// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CancelCoordinationForMonitoringRequest : TeaModel {
        /// <summary>
        /// The IDs of stream collaboration tasks.
        /// </summary>
        [NameInMap("CoIds")]
        [Validation(Required=false)]
        public List<string> CoIds { get; set; }

        /// <summary>
        /// The ID of the end user that initiates stream collaboration. If the initiator is the administrator, skip this parameter.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~436773~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the user.
        /// 
        /// Valid value:
        /// 
        /// * TENANT_ADMIN: administrator.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
