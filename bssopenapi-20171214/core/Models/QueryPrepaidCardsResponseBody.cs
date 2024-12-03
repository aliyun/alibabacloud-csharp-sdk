// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPrepaidCardsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
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
                /// <para>The services to which the prepaid card is applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>All Alibaba Cloud services</para>
                /// </summary>
                [NameInMap("ApplicableProducts")]
                [Validation(Required=false)]
                public string ApplicableProducts { get; set; }

                /// <summary>
                /// <para>The scenario to which the prepaid card is applicable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApplicableScenarios")]
                [Validation(Required=false)]
                public string ApplicableScenarios { get; set; }

                /// <summary>
                /// <para>The balance of the prepaid card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("Balance")]
                [Validation(Required=false)]
                public string Balance { get; set; }

                /// <summary>
                /// <para>The time when the prepaid card took effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-03T01:39:11Z</para>
                /// </summary>
                [NameInMap("EffectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                /// <summary>
                /// <para>The time when the prepaid card expired.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-04T01:39:11Z</para>
                /// </summary>
                [NameInMap("ExpiryTime")]
                [Validation(Required=false)]
                public string ExpiryTime { get; set; }

                /// <summary>
                /// <para>The time when the prepaid card was issued.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-03T01:39:11Z</para>
                /// </summary>
                [NameInMap("GrantedTime")]
                [Validation(Required=false)]
                public string GrantedTime { get; set; }

                /// <summary>
                /// <para>The nominal value of the prepaid card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.00</para>
                /// </summary>
                [NameInMap("NominalValue")]
                [Validation(Required=false)]
                public string NominalValue { get; set; }

                /// <summary>
                /// <para>The ID of the prepaid card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>213432432</para>
                /// </summary>
                [NameInMap("PrepaidCardId")]
                [Validation(Required=false)]
                public long? PrepaidCardId { get; set; }

                /// <summary>
                /// <para>The number of the prepaid card.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Q-7edaab979fc9</para>
                /// </summary>
                [NameInMap("PrepaidCardNo")]
                [Validation(Required=false)]
                public string PrepaidCardNo { get; set; }

                /// <summary>
                /// <para>The status of the prepaid card. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Available: The prepaid card is valid.</description></item>
                /// <item><description>Expired: The prepaid card expired.</description></item>
                /// <item><description>Cancelled: The prepaid card is invalid.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
