// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class SearchInfoRequest : TeaModel {
        [NameInMap("KnowledgeBaseFilters")]
        [Validation(Required=false)]
        public List<SearchInfoRequestKnowledgeBaseFilters> KnowledgeBaseFilters { get; set; }
        public class SearchInfoRequestKnowledgeBaseFilters : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pai_qa</para>
            /// </summary>
            [NameInMap("CollectionName")]
            [Validation(Required=false)]
            public string CollectionName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>what is pai</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public int? ResultLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7827883223</para>
            /// </summary>
            [NameInMap("ScoreThreshold")]
            [Validation(Required=false)]
            public double? ScoreThreshold { get; set; }

        }

        [NameInMap("WebFilters")]
        [Validation(Required=false)]
        public List<SearchInfoRequestWebFilters> WebFilters { get; set; }
        public class SearchInfoRequestWebFilters : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("IncludeSites")]
            [Validation(Required=false)]
            public List<string> IncludeSites { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>what is dsw</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ResultLimit")]
            [Validation(Required=false)]
            public int? ResultLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.832883223</para>
            /// </summary>
            [NameInMap("ScoreThreshold")]
            [Validation(Required=false)]
            public double? ScoreThreshold { get; set; }

        }

    }

}
