// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RunAppInstanceCommandResponseBody : TeaModel {
        /// <summary>
        /// <para>The command issuance result.</para>
        /// </summary>
        [NameInMap("CommandResultModel")]
        [Validation(Required=false)]
        public RunAppInstanceCommandResponseBodyCommandResultModel CommandResultModel { get; set; }
        public class RunAppInstanceCommandResponseBodyCommandResultModel : TeaModel {
            /// <summary>
            /// <para>The command execution ID. Only one execution ID is returned even when commands are issued in batches to multiple delivery groups. You can use this ID to call ListCommandInvocationResults to query the command execution results on each session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-hz0jdfwd9f****</para>
            /// </summary>
            [NameInMap("InvocationId")]
            [Validation(Required=false)]
            public string InvocationId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
