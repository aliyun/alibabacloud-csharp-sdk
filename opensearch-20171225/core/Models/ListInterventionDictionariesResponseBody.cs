// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionariesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A6EB64B-B4C8-CF02-810F-E660812972FF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about each intervention dictionary.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/173608.html">InterventionDictionary</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInterventionDictionariesResponseBodyResult> Result { get; set; }
        public class ListInterventionDictionariesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The custom analyzer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("analyzer")]
            [Validation(Required=false)]
            public string Analyzer { get; set; }

            /// <summary>
            /// <para>The time when the intervention dictionary was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1539158325</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The ID of the intervention dictionary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The name of the intervention dictionary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tongyici</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the intervention dictionary. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>stopword: an intervention dictionary for stop word filtering</description></item>
            /// <item><description>synonym: an intervention dictionary for synonym configuration</description></item>
            /// <item><description>correction: an intervention dictionary for spelling correction</description></item>
            /// <item><description>category_prediction: an intervention dictionary for category prediction</description></item>
            /// <item><description>ner: an intervention dictionary for named entity recognition (NER)</description></item>
            /// <item><description>term_weighting: an intervention dictionary for term weight analysis</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>synonym</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the intervention dictionary was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1539158313</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
