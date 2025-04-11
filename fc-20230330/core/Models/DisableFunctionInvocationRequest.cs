// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DisableFunctionInvocationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to immediately terminate all ongoing requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("abortOngoingRequest")]
        [Validation(Required=false)]
        public bool? AbortOngoingRequest { get; set; }

        /// <summary>
        /// <para>The reason for disabling the function\&quot;s invocation.</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
