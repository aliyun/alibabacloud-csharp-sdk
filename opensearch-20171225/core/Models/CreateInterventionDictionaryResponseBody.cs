// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateInterventionDictionaryResponseBody : TeaModel {
        /// <summary>
        /// The type of the intervention dictionary. Valid values:
        /// 
        /// *   stopword: an intervention dictionary for stop word filtering
        /// *   synonym: an intervention dictionary for synonym configuration
        /// *   correction: an intervention dictionary for spelling correction
        /// *   category_prediction: an intervention dictionary for category prediction
        /// *   ner: an intervention dictionary for named entity recognition (NER)
        /// *   term_weighting: an intervention dictionary for term weight analysis
        /// *   suggest_allowlist: a drop-down suggestion whitelist
        /// *   suggest_denylist: a drop-down suggestion blacklist
        /// *   hot_allowlist: a top search whitelist
        /// *   hot_denylist: a top search blacklist
        /// *   hint_allowlist: a shading whitelist
        /// *   hint_denylist: a shading blacklist
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateInterventionDictionaryResponseBodyResult Result { get; set; }
        public class CreateInterventionDictionaryResponseBodyResult : TeaModel {
            /// <summary>
            /// Creates an intervention dictionary.
            /// </summary>
            [NameInMap("analyzer")]
            [Validation(Required=false)]
            public string Analyzer { get; set; }

            /// <summary>
            /// The name of the intervention dictionary.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// CreateInterventionDictionary
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
