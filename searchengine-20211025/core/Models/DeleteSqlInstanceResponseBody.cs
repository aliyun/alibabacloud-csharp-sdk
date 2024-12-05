// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DeleteSqlInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response&lt;Map&lt;String, String&gt;&gt;</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteSqlInstanceResponseBodyResult Result { get; set; }
        public class DeleteSqlInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>id of request</para>
            /// 
            /// <b>Example:</b>
            /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The result.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public Dictionary<string, string> Result { get; set; }

        }

    }

}
