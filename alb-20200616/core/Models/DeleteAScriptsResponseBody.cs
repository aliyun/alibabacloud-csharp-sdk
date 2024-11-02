// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DeleteAScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The asynchronous task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03cf3fe1-ab37-479b-92a6-b481d762****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B7B7695-3596-50C8-B739-030C6C685E61</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
