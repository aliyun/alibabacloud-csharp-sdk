// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateInterventionDictionaryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateInterventionDictionaryResponseBodyResult Result { get; set; }
        public class CreateInterventionDictionaryResponseBodyResult : TeaModel {
            /// <summary>
            /// The custom analyzer.
            /// </summary>
            [NameInMap("analyzer")]
            [Validation(Required=false)]
            public string Analyzer { get; set; }

            /// <summary>
            /// The time when the test scenario was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The name of the test group.
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
            public string Updated { get; set; }

        }

    }

}
