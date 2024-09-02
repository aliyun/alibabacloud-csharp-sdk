// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionariesRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        [NameInMap("types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
