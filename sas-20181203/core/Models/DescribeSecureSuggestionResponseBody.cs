// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecureSuggestionResponseBody : TeaModel {
        /// <summary>
        /// 192.168.XX.XX
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Queries suggestions on how to handle the security risks that affect the security score.
        /// </summary>
        [NameInMap("Suggestions")]
        [Validation(Required=false)]
        public List<DescribeSecureSuggestionResponseBodySuggestions> Suggestions { get; set; }
        public class DescribeSecureSuggestionResponseBodySuggestions : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSecureSuggestionResponseBodySuggestionsDetail> Detail { get; set; }
            public class DescribeSecureSuggestionResponseBodySuggestionsDetail : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// DescribeSecureSuggestion
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public int? Points { get; set; }

            [NameInMap("SuggestType")]
            [Validation(Required=false)]
            public string SuggestType { get; set; }

        }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
