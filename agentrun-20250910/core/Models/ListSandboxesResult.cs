// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListSandboxesResult : TeaModel {
        /// <summary>
        /// <para>The status of the request. A value of \&quot;SUCCESS\&quot; indicates that the request was successful. If the request fails, an error code is returned, such as \&quot;ERR_BAD_REQUEST\&quot;, \&quot;ERR_VALIDATION_FAILED\&quot;, or \&quot;ERR_INTERNAL_SERVER_ERROR\&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Contains the list of sandboxes.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSandboxesOutput Data { get; set; }

        /// <summary>
        /// <para>The unique request ID used for issue tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55D4BE40-2811-5CFB-8482-E0E98D575B1E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
