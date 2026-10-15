// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPrepaidCardsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPrepaidCardsResponseBodyData Data { get; set; }
        public class QueryPrepaidCardsResponseBodyData : TeaModel {
            [NameInMap("PrepaidCard")]
            [Validation(Required=false)]
            public List<QueryPrepaidCardsResponseBodyDataPrepaidCard> PrepaidCard { get; set; }
            public class QueryPrepaidCardsResponseBodyDataPrepaidCard : TeaModel {
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                [NameInMap("ApplicableScenarios")]
                [Validation(Required=false)]
                public string ApplicableScenarios { get; set; }

                [NameInMap("Balance")]
                [Validation(Required=false)]
                public string Balance { get; set; }

                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                [NameInMap("ExpiryTime")]
                [Validation(Required=false)]
                public string ExpiryTime { get; set; }

                [NameInMap("GrantedTime")]
                [Validation(Required=false)]
                public string GrantedTime { get; set; }

                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                [NameInMap("PrepaidCardId")]
                [Validation(Required=false)]
                public long? PrepaidCardId { get; set; }

                [NameInMap("PrepaidCardNo")]
                [Validation(Required=false)]
                public string PrepaidCardNo { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7EA6C02D-06D0-4213-9C3B-E67910F7D1EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
