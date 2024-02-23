// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskCallListRequest : TeaModel {
        /// <summary>
        /// The call result. Valid values:
        /// 
        /// *   **200002**: The line is busy.
        /// *   **200005**: The called party cannot be connected.
        /// *   **200010**: The phone of the called party is powered off.
        /// *   **200011**: The called party is out of service.
        /// *   **200012**: The call is lost.
        /// </summary>
        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        /// <summary>
        /// The called number.
        /// </summary>
        [NameInMap("Called")]
        [Validation(Required=false)]
        public string Called { get; set; }

        /// <summary>
        /// The minimum number of conversation rounds in the call.
        /// </summary>
        [NameInMap("DialogCountFrom")]
        [Validation(Required=false)]
        public string DialogCountFrom { get; set; }

        /// <summary>
        /// The maximum number of conversation rounds in the call.
        /// </summary>
        [NameInMap("DialogCountTo")]
        [Validation(Required=false)]
        public string DialogCountTo { get; set; }

        /// <summary>
        /// The minimum call duration.
        /// </summary>
        [NameInMap("DurationFrom")]
        [Validation(Required=false)]
        public string DurationFrom { get; set; }

        /// <summary>
        /// The maximum call duration.
        /// </summary>
        [NameInMap("DurationTo")]
        [Validation(Required=false)]
        public string DurationTo { get; set; }

        /// <summary>
        /// The party who hangs up. Valid values:
        /// 
        /// *   **0**: the called party.
        /// *   **1**: the robot.
        /// </summary>
        [NameInMap("HangupDirection")]
        [Validation(Required=false)]
        public string HangupDirection { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        public string TaskId { get; set; }

    }

}
