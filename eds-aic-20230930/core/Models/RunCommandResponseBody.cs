// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunCommandResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the command execution. You can use the command execution ID to query the output of a command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-gov2ujrk32v4****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>440D7342-5E7C-B2DB-D0B4EAC2BDF1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
