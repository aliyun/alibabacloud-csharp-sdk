// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class GetInstanceLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>p-123****</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetInstanceLogResponseBodyData Data { get; set; }
        public class GetInstanceLogResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("lineNum")]
            [Validation(Required=false)]
            public long? LineNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;logs&quot;</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
