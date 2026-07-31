// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ListSemanticViewNamesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSemanticViewNamesResponseBodyData> Data { get; set; }
        public class ListSemanticViewNamesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The annotation of the semantic view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个定义销售额相关指标的视图</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The name of the semantic view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>revenue_analysis</para>
            /// </summary>
            [NameInMap("ViewName")]
            [Validation(Required=false)]
            public string ViewName { get; set; }

            /// <summary>
            /// <para>The schema in which the semantic view resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sales_db</para>
            /// </summary>
            [NameInMap("ViewSchema")]
            [Validation(Required=false)]
            public string ViewSchema { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
