// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionaryNerResultsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The NER result.
        /// 
        /// For more information, see [InterventionDictionaryEntry](https://help.aliyun.com/document_detail/173606.html).
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInterventionDictionaryNerResultsResponseBodyResult> Result { get; set; }
        public class ListInterventionDictionaryNerResultsResponseBodyResult : TeaModel {
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

    }

}
