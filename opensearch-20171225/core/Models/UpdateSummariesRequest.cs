// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateSummariesRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateSummariesRequestBody> Body { get; set; }
        public class UpdateSummariesRequestBody : TeaModel {
            /// <summary>
            /// <para>The HTML tag that is used to highlight terms in red.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;em&quot;</para>
            /// </summary>
            [NameInMap("element")]
            [Validation(Required=false)]
            public string Element { get; set; }

            /// <summary>
            /// <para>The connector that is used to connect segments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;...&quot;</para>
            /// </summary>
            [NameInMap("ellipsis")]
            [Validation(Required=false)]
            public string Ellipsis { get; set; }

            /// <summary>
            /// <para>The field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;title&quot;</para>
            /// </summary>
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The length of a segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("len")]
            [Validation(Required=false)]
            public int? Len { get; set; }

            /// <summary>
            /// <para>The number of segments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("snippet")]
            [Validation(Required=false)]
            public int? Snippet { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the request is a dry run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
