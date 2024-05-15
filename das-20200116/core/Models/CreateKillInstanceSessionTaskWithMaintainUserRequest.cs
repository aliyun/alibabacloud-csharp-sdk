// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateKillInstanceSessionTaskWithMaintainUserRequest : TeaModel {
        [NameInMap("IgnoredUsers")]
        [Validation(Required=false)]
        public string IgnoredUsers { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("KillAllSessions")]
        [Validation(Required=false)]
        public bool? KillAllSessions { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("SessionIds")]
        [Validation(Required=false)]
        public string SessionIds { get; set; }

    }

}
