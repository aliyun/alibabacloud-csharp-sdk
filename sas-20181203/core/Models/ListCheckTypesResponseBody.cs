// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckTypesResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCheckTypesResponseBodyData> Data { get; set; }
        public class ListCheckTypesResponseBodyData : TeaModel {
            /// <summary>
            /// The detail of check items.
            /// </summary>
            [NameInMap("CheckDetails")]
            [Validation(Required=false)]
            public List<ListCheckTypesResponseBodyDataCheckDetails> CheckDetails { get; set; }
            public class ListCheckTypesResponseBodyDataCheckDetails : TeaModel {
                /// <summary>
                /// The list of the baseline categories of attribution.
                /// </summary>
                [NameInMap("AffiliatedRiskTypes")]
                [Validation(Required=false)]
                public List<string> AffiliatedRiskTypes { get; set; }

                /// <summary>
                /// The list of baselines attribution.
                /// </summary>
                [NameInMap("AffiliatedRisks")]
                [Validation(Required=false)]
                public List<string> AffiliatedRisks { get; set; }

                /// <summary>
                /// The ID of the check item.
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                /// <summary>
                /// The description of the check item.
                /// </summary>
                [NameInMap("CheckItem")]
                [Validation(Required=false)]
                public string CheckItem { get; set; }

            }

            /// <summary>
            /// The type of the check item.
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// The display name of the check item type.
            /// </summary>
            [NameInMap("CheckTypeDisName")]
            [Validation(Required=false)]
            public string CheckTypeDisName { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
