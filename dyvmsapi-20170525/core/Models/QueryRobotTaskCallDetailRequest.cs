// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskCallDetailRequest : TeaModel {
        /// <summary>
        /// The called number.
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The timestamp of the time at which the call details you want to query.
        /// </summary>
        [NameInMap("QueryDate")]
        [Validation(Required=false)]
        public long? QueryDate { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The unique ID of the robocall task. You can call the [CreateRobotTask](~~393531~~) operation to obtain the task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
