// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionaryEntriesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about intervention entries.
        /// 
        /// For more information, see [InterventionDictionaryEntry](https://help.aliyun.com/document_detail/173606.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInterventionDictionaryEntriesResponseBodyResult> Result { get; set; }
        public class ListInterventionDictionaryEntriesResponseBodyResult : TeaModel {
            /// <summary>
            /// The command. Valid values:
            /// 
            /// *   add
            /// *   delete
            /// </summary>
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            /// <summary>
            /// The timestamp when the intervention entry was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// The content of an intervention entry for category prediction. The field value consists of key-value pairs. The key in a key-value pair indicates the ID of the category. The value in a key-value pair indicates the relevance to the category. A value of 0 indicates irrelevant. A value of 1 indicates slightly relevant. A value of 2 indicates relevant. Example: {"2":1, "100":0}
            /// </summary>
            [NameInMap("relevance")]
            [Validation(Required=false)]
            public Dictionary<string, object> Relevance { get; set; }

            /// <summary>
            /// The status of the intervention entry. Valid value:
            /// 
            /// *   ACTIVE: The intervention entry takes effect.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The content of the intervention entry for term weight analysis.
            /// </summary>
            [NameInMap("tokens")]
            [Validation(Required=false)]
            public List<ListInterventionDictionaryEntriesResponseBodyResultTokens> Tokens { get; set; }
            public class ListInterventionDictionaryEntriesResponseBodyResultTokens : TeaModel {
                /// <summary>
                /// The sequence number.
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// The internal name of the identified entity type. Valid values:
                /// 
                /// *   brand
                /// *   category
                /// *   material
                /// *   element
                /// *   style
                /// *   color
                /// *   function
                /// *   scenario
                /// *   people
                /// *   season
                /// *   model
                /// *   region
                /// *   name
                /// *   adjective
                /// *   category-modifier
                /// *   size
                /// *   quality
                /// *   suit
                /// *   new-release
                /// *   series
                /// *   marketing
                /// *   entertainment
                /// *   organization
                /// *   movie
                /// *   game
                /// *   number
                /// *   unit
                /// *   common
                /// *   new-word
                /// *   proper-noun
                /// *   symbol
                /// *   prefix
                /// *   suffix
                /// *   gift
                /// *   negative
                /// *   agent
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The description of the internal name of the identified entity type.
                /// </summary>
                [NameInMap("tagLabel")]
                [Validation(Required=false)]
                public string TagLabel { get; set; }

                /// <summary>
                /// The entity.
                /// </summary>
                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

            }

            /// <summary>
            /// The timestamp when the intervention entry was last updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public long? Updated { get; set; }

            /// <summary>
            /// The intervention entry.
            /// </summary>
            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
