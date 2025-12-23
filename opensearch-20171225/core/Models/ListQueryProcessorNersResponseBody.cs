// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQueryProcessorNersResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A6EB64B-B4C8-CF02-810F-E660812972FF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The priority settings of entity types.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/173616.html">Priority settings of entity types</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListQueryProcessorNersResponseBodyResult> Result { get; set; }
        public class ListQueryProcessorNersResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The name of the entity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>brand</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The priority of an entity type among entity types that have the same priority level. A smaller value indicates a higher priority. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The priority level of the entity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HIGH</description></item>
            /// <item><description>MIDDLE</description></item>
            /// <item><description>LOW</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The internal name of the entity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>brand</para>
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

    }

}
