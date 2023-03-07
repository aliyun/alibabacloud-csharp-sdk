// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPrepaidCardsResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPrepaidCardsResponseBodyData Data { get; set; }
        public class QueryPrepaidCardsResponseBodyData : TeaModel {
            [NameInMap("PrepaidCard")]
            [Validation(Required=false)]
            public List<QueryPrepaidCardsResponseBodyDataPrepaidCard> PrepaidCard { get; set; }
            public class QueryPrepaidCardsResponseBodyDataPrepaidCard : TeaModel {
                /// <summary>
                /// The services to which the prepaid card is applicable.
                /// </summary>
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                /// <summary>
                /// The scenario to which the prepaid card is applicable.
                /// </summary>
                [NameInMap("ApplicableScenarios")]
                [Validation(Required=false)]
                public string ApplicableScenarios { get; set; }

                /// <summary>
                /// The balance of the prepaid card.
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public string Balance { get; set; }

                /// <summary>
                /// The time when the prepaid card took effect.
                /// </summary>
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                /// <summary>
                /// The time when the prepaid card expired.
                /// </summary>
                [NameInMap("ExpiryTime")]
                [Validation(Required=false)]
                public string ExpiryTime { get; set; }

                /// <summary>
                /// The time when the prepaid card was issued.
                /// </summary>
                [NameInMap("GrantedTime")]
                [Validation(Required=false)]
                public string GrantedTime { get; set; }

                /// <summary>
                /// The nominal value of the prepaid card.
                /// </summary>
                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                /// <summary>
                /// The ID of the prepaid card.
                /// </summary>
                [NameInMap("PrepaidCardId")]
                [Validation(Required=false)]
                public long? PrepaidCardId { get; set; }

                /// <summary>
                /// The number of the prepaid card.
                /// </summary>
                [NameInMap("PrepaidCardNo")]
                [Validation(Required=false)]
                public string PrepaidCardNo { get; set; }

                /// <summary>
                /// The status of the prepaid card. Valid values:
                /// 
                /// *   Available: The prepaid card is valid.
                /// *   Expired: The prepaid card expired.
                /// *   Cancelled: The prepaid card is invalid.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
