// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceMaintainTimeRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The end time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC. For example, if you want the maintenance window to end at 2:00 (UTC+8), set this parameter to `18:00Z`.
        /// 
        /// >  The interval between the start time and the end time cannot be less than 1 hour.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// The start time of the maintenance window. The time is in the *HH:mm*Z format. The time is displayed in UTC. For example, if you want the maintenance to start at 1:00 (UTC+8), set this parameter to `17:00Z`. After you call the API operation, you can view the actual time in the ApsaraDB for Redis console. For more information, see [Set a maintenance window](https://help.aliyun.com/document_detail/55252.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
