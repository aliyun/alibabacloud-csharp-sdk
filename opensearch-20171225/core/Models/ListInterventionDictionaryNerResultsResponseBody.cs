// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionaryNerResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F780CA8-D4D4-2FFE-B8AC-42040822C554</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The NER result.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/173606.html">InterventionDictionaryEntry</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInterventionDictionaryNerResultsResponseBodyResult> Result { get; set; }
        public class ListInterventionDictionaryNerResultsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The internal name of the identified entity type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>brand</description></item>
            /// <item><description>category</description></item>
            /// <item><description>material</description></item>
            /// <item><description>element</description></item>
            /// <item><description>style</description></item>
            /// <item><description>color</description></item>
            /// <item><description>function</description></item>
            /// <item><description>scenario</description></item>
            /// <item><description>people</description></item>
            /// <item><description>season</description></item>
            /// <item><description>model</description></item>
            /// <item><description>region</description></item>
            /// <item><description>name</description></item>
            /// <item><description>adjective</description></item>
            /// <item><description>category-modifier</description></item>
            /// <item><description>size</description></item>
            /// <item><description>quality</description></item>
            /// <item><description>suit</description></item>
            /// <item><description>new-release</description></item>
            /// <item><description>series</description></item>
            /// <item><description>marketing</description></item>
            /// <item><description>entertainment</description></item>
            /// <item><description>organization</description></item>
            /// <item><description>movie</description></item>
            /// <item><description>game</description></item>
            /// <item><description>number</description></item>
            /// <item><description>unit</description></item>
            /// <item><description>common</description></item>
            /// <item><description>new-word</description></item>
            /// <item><description>proper-noun</description></item>
            /// <item><description>symbol</description></item>
            /// <item><description>prefix</description></item>
            /// <item><description>suffix</description></item>
            /// <item><description>gift</description></item>
            /// <item><description>negative</description></item>
            /// <item><description>agent</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>category</para>
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The description of the internal name of the identified entity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>category</para>
            /// </summary>
            [NameInMap("tagLabel")]
            [Validation(Required=false)]
            public string TagLabel { get; set; }

            /// <summary>
            /// <para>The entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eaa73f35-007a-4be7-88c7-37dca4a04ab7</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

    }

}
