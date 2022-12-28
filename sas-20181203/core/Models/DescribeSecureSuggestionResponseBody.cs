// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecureSuggestionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the unhandled security risks.
        /// </summary>
        [NameInMap("Suggestions")]
        [Validation(Required=false)]
        public List<DescribeSecureSuggestionResponseBodySuggestions> Suggestions { get; set; }
        public class DescribeSecureSuggestionResponseBodySuggestions : TeaModel {
            /// <summary>
            /// An array that consists of the details about the suggestion.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSecureSuggestionResponseBodySuggestionsDetail> Detail { get; set; }
            public class DescribeSecureSuggestionResponseBodySuggestionsDetail : TeaModel {
                /// <summary>
                /// The description of the suggestion.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The subtype of the unhandled security risk.
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// The name of the unhandled risk.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// The penalty point of an item.
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public int? Points { get; set; }

            /// <summary>
            /// The type of the unhandled security risk. Valid values:
            /// 
            /// *   **SS_REINFORCE**: missing configuration of key features, such as the antivirus feature
            /// *   **SS_ALARM**: unhandled alerts
            /// *   **SS_VUL**: unfixed vulnerabilities
            /// *   **SS_HC**: baseline risks
            /// *   **SS_AK**: AccessKey pair leaks
            /// *   **SS_CLOUD_HC**: configuration risks of cloud services
            /// *   **OTHER**: others
            /// </summary>
            [NameInMap("SuggestType")]
            [Validation(Required=false)]
            public string SuggestType { get; set; }

        }

        /// <summary>
        /// The total number of unhandled security risks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
