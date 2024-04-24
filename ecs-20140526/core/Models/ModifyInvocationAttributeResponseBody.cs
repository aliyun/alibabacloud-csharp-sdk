// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInvocationAttributeResponseBody : TeaModel {
        /// <summary>
        /// The command ID.
        /// 
        /// *   A new command is added and the `CommandId` value of the new command is returned only when `CommandContent` is changed.
        /// *   No new command is added and the `CommandId` value of the command that is running is returned if `CommandContent` is not changed.
        /// *   If you set `KeepCommand` to `true` when you called the [InvokeCommand](~~64841~~) or [RunCommand](~~141751~~) operation, a new command is added and retained. Otherwise, commands related to the task are deleted after all executions of the task are complete or the task is manually stopped.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
