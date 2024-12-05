// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListOnlineConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E45380E8-994A-5402-9806-F114B3295FCF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListOnlineConfigsResponseBodyResult> Result { get; set; }
        public class ListOnlineConfigsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The configuration information</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;specItems\&quot;:[{\&quot;specKey\&quot;:\&quot;YQ_KEYWORD_NUMBER_PLUS\&quot;,\&quot;value\&quot;:\&quot;1\&quot;}]}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The name of the index</para>
            /// 
            /// <b>Example:</b>
            /// <para>generation</para>
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

        }

    }

}
