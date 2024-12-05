// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAliasesResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>10D5E615-69F7-5F49-B850-00169ADE513C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAliasesResponseBodyResult> Result { get; set; }
        public class ListAliasesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>alias name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>index name</para>
            /// 
            /// <b>Example:</b>
            /// <para>index</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public string Index { get; set; }

        }

    }

}
