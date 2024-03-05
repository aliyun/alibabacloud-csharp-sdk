// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InvokeShellCommandResponseBody : TeaModel {
        /// <summary>
        /// The ID of the command. It is used to query the execution status of the command.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The list of IDs of the instances on which you want to run the command.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public InvokeShellCommandResponseBodyInstanceIds InstanceIds { get; set; }
        public class InvokeShellCommandResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
