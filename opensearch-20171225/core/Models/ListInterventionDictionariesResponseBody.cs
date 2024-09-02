// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionariesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about each intervention dictionary.
        /// 
        /// For more information, see [InterventionDictionary](https://help.aliyun.com/document_detail/173608.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInterventionDictionariesResponseBodyResult> Result { get; set; }
        public class ListInterventionDictionariesResponseBodyResult : TeaModel {
            /// <summary>
            /// The custom analyzer.
            /// </summary>
            [NameInMap("analyzer")]
            [Validation(Required=false)]
            public string Analyzer { get; set; }

            /// <summary>
            /// The time when the intervention dictionary was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The ID of the intervention dictionary.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The name of the intervention dictionary.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the intervention dictionary. Valid values:
            /// 
            /// *   stopword: an intervention dictionary for stop word filtering
            /// *   synonym: an intervention dictionary for synonym configuration
            /// *   correction: an intervention dictionary for spelling correction
            /// *   category_prediction: an intervention dictionary for category prediction
            /// *   ner: an intervention dictionary for named entity recognition (NER)
            /// *   term_weighting: an intervention dictionary for term weight analysis
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The time when the intervention dictionary was last updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
