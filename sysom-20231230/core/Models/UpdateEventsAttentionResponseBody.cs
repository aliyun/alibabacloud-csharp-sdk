// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateEventsAttentionResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>44841312-7227-55C9-AE03-D59729BFAE38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code:  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded;  </description></item>
        /// <item><description>Other status codes indicate that authorization failed. When authorization fails, view the <c>message</c> field to obtain the detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateEventsAttentionResponseBodyData Data { get; set; }
        public class UpdateEventsAttentionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Updated follow level value</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

        }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance not belong to current user</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
