// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRedeemResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRedeemResponseBodyData Data { get; set; }
        public class QueryRedeemResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Redeem")]
            [Validation(Required=false)]
            public QueryRedeemResponseBodyDataRedeem Redeem { get; set; }
            public class QueryRedeemResponseBodyDataRedeem : TeaModel {
                [NameInMap("Redeem")]
                [Validation(Required=false)]
                public List<QueryRedeemResponseBodyDataRedeemRedeem> Redeem { get; set; }
                public class QueryRedeemResponseBodyDataRedeemRedeem : TeaModel {
                    [NameInMap("ApplicableProducts")]
                    [Validation(Required=false)]
                    public string ApplicableProducts { get; set; }

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

                    [NameInMap("RedeemId")]
                    [Validation(Required=false)]
                    public string RedeemId { get; set; }

                    [NameInMap("RedeemNo")]
                    [Validation(Required=false)]
                    public string RedeemNo { get; set; }

                    [NameInMap("Specification")]
                    [Validation(Required=false)]
                    public string Specification { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E503DC7B-E4F0-4B3C-BC89-BCECF1338F0B</para>
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
