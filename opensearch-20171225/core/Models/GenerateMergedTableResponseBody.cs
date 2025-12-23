// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GenerateMergedTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCDEFGH</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GenerateMergedTableResponseBodyResult Result { get; set; }
        public class GenerateMergedTableResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The tables on which the JOIN operation is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("fromTable")]
            [Validation(Required=false)]
            public Dictionary<string, object> FromTable { get; set; }

            /// <summary>
            /// <para>The wide table that is generated after the JOIN operation is performed on multiple tables.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("mergeTable")]
            [Validation(Required=false)]
            public Dictionary<string, object> MergeTable { get; set; }

            /// <summary>
            /// <para>The primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

        }

    }

}
