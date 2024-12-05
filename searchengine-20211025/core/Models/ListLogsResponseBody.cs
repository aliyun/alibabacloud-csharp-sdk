// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>ListResult</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListLogsResponseBodyResult Result { get; set; }
        public class ListLogsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The result.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<object> Result { get; set; }

            /// <summary>
            /// <para>The total number of entries returned</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
