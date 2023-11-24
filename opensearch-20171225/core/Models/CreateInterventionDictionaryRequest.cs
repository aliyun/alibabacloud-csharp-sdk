// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateInterventionDictionaryRequest : TeaModel {
        /// <summary>
        /// The type of the analyzer. Valid values:
        /// 
        /// *   MODEL: model-based custom analyzer.
        /// *   SYSTEM: system analyzer.
        /// *   USER: custom analyzer.
        /// </summary>
        [NameInMap("analyzerType")]
        [Validation(Required=false)]
        public string AnalyzerType { get; set; }

        /// <summary>
        /// The name of the intervention dictionary.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the intervention dictionary. Valid values:
        /// 
        /// *   stopword: an intervention dictionary for stop word filtering.
        /// *   synonym: an intervention dictionary for synonym configuration.
        /// *   correction: an intervention dictionary for spelling correction.
        /// *   category_prediction: an intervention dictionary for category prediction.
        /// *   ner: an intervention dictionary for named entity recognition (NER).
        /// *   term_weighting: an intervention dictionary for term weight analysis.
        /// *   suggest_allowlist: a drop-down suggestion whitelist.
        /// *   suggest_denylist: a drop-down suggestion blacklist.
        /// *   hot_allowlist: a top search whitelist.
        /// *   hot_denylist: a top search blacklist.
        /// *   hint_allowlist: a hint whitelist.
        /// *   hint_denylist: a hint blacklist.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Default value: false.
        /// 
        /// Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
