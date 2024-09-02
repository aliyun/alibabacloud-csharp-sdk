// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListUserAnalyzersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The custom analyzer.
        /// 
        /// For more information, see [UserAnalyzer](https://help.aliyun.com/document_detail/178934.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListUserAnalyzersResponseBodyResult> Result { get; set; }
        public class ListUserAnalyzersResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the application is available.
            /// </summary>
            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            /// <summary>
            /// The basic analyzer. Valid values:
            /// 
            /// *   chn_standard: [a common analyzer in Chinese](https://help.aliyun.com/document_detail/179424.html)
            /// *   chn_scene_name: an analyzer for person names in Chinese
            /// *   chn_ecommerce: [an analyzer for E-commerce in Chinese](https://help.aliyun.com/document_detail/179424.html)
            /// *   chn_it_content: [an analyzer for IT content in Chinese](https://help.aliyun.com/document_detail/179424.html)
            /// *   en_min: a small-granularity analyzer in English
            /// *   th_standard: a common analyzer in Thai
            /// *   th_ecommerce: an analyzer for E-commerce in Thai
            /// *   vn_standard: a common analyzer in Vietnamese
            /// *   chn_community_it: an analyzer for IT community content in Chinese
            /// *   chn_ecommerce_general: a common analyzer for the E-commerce industry in Chinese
            /// *   chn_esports_general: a common analyzer for the gaming industry in Chinese
            /// *   chn_edu_question: an analyzer for question search of the education industry in Chinese
            /// </summary>
            [NameInMap("business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            /// <summary>
            /// The timestamp when the application was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The dictionaries that are used by the custom analyzer.
            /// 
            /// For more information, see [UserDict](https://help.aliyun.com/document_detail/178933.html).
            /// </summary>
            [NameInMap("dicts")]
            [Validation(Required=false)]
            public List<ListUserAnalyzersResponseBodyResultDicts> Dicts { get; set; }
            public class ListUserAnalyzersResponseBodyResultDicts : TeaModel {
                /// <summary>
                /// Indicates whether the application is available.
                /// </summary>
                [NameInMap("available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                /// <summary>
                /// The timestamp when the application was created.
                /// </summary>
                [NameInMap("created")]
                [Validation(Required=false)]
                public int? Created { get; set; }

                /// <summary>
                /// The number of intervention entries.
                /// </summary>
                [NameInMap("entriesCount")]
                [Validation(Required=false)]
                public int? EntriesCount { get; set; }

                /// <summary>
                /// The maximum number of intervention entries that can be created in the dictionary.
                /// </summary>
                [NameInMap("entriesLimit")]
                [Validation(Required=false)]
                public int? EntriesLimit { get; set; }

                /// <summary>
                /// The ID of the dictionary.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The type. Valid value:
                /// 
                /// *   segment
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The timestamp when the application was last updated.
                /// </summary>
                [NameInMap("updated")]
                [Validation(Required=false)]
                public int? Updated { get; set; }

            }

            /// <summary>
            /// The ID of the custom analyzer.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the custom analyzer.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The timestamp when the application was last updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        /// <summary>
        /// The total number.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
