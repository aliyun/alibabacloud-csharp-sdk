// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetCoordinateTicketRequest : TeaModel {
        /// <summary>
        /// The ID of the stream collaboration. You can obtain the value of this parameter based on the value of `Coid` that is returned by the `ApplyCoordinationForMonitoring` operation.
        /// </summary>
        [NameInMap("CoId")]
        [Validation(Required=false)]
        public string CoId { get; set; }

        /// <summary>
        /// The name of the convenience user account. If you initiate the request as an administrator, you do not need to specify this parameter.
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
        /// The ID of the cloud computer connection task. The first time you initiate the request, you do not need to specify the ID of the cloud computer connection task. If no ticket is returned after you initiate the first request, you must specify the value of taskId that is returned for the first request in the subsequent request.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The type of the user.
        /// 
        /// Set the value to TENANT_ADMIN.
        /// 
        /// *   The value of
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     TENANT_ADMIN
        /// 
        ///     <!-- -->
        /// 
        ///     specifies an administrator.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
