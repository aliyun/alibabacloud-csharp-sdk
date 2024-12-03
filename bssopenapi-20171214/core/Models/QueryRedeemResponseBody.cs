// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRedeemResponseBody : TeaModel {
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
        public QueryRedeemResponseBodyData Data { get; set; }
        public class QueryRedeemResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The details of the redemption coupon.</para>
            /// </summary>
            [NameInMap("Redeem")]
            [Validation(Required=false)]
            public QueryRedeemResponseBodyDataRedeem Redeem { get; set; }
            public class QueryRedeemResponseBodyDataRedeem : TeaModel {
                [NameInMap("Redeem")]
                [Validation(Required=false)]
                public List<QueryRedeemResponseBodyDataRedeemRedeem> Redeem { get; set; }
                public class QueryRedeemResponseBodyDataRedeemRedeem : TeaModel {
                    /// <summary>
                    /// <para>The services to which the redemption coupon is applicable.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Elastic Compute Service (ECS)</para>
                    /// </summary>
                    [NameInMap("ApplicableProducts")]
                    [Validation(Required=false)]
                    public string ApplicableProducts { get; set; }

                    /// <summary>
                    /// <para>The balance of the redemption coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Balance")]
                    [Validation(Required=false)]
                    public string Balance { get; set; }

                    /// <summary>
                    /// <para>The time when the redemption coupon took effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-05-14 20:25:00</para>
                    /// </summary>
                    [NameInMap("EffectiveTime")]
                    [Validation(Required=false)]
                    public string EffectiveTime { get; set; }

                    /// <summary>
                    /// <para>The time when the redemption coupon expired.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-06-13 20:25:00</para>
                    /// </summary>
                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public string ExpiryTime { get; set; }

                    /// <summary>
                    /// <para>The time when the redemption coupon was issued.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-05-14 20:25:00</para>
                    /// </summary>
                    [NameInMap("GrantedTime")]
                    [Validation(Required=false)]
                    public string GrantedTime { get; set; }

                    /// <summary>
                    /// <para>The nominal value of the redemption coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("NominalValue")]
                    [Validation(Required=false)]
                    public string NominalValue { get; set; }

                    /// <summary>
                    /// <para>The ID of the redemption coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1342</para>
                    /// </summary>
                    [NameInMap("RedeemId")]
                    [Validation(Required=false)]
                    public string RedeemId { get; set; }

                    /// <summary>
                    /// <para>The number of the redemption coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4889*****1610</para>
                    /// </summary>
                    [NameInMap("RedeemNo")]
                    [Validation(Required=false)]
                    public string RedeemNo { get; set; }

                    /// <summary>
                    /// <para>The specifications of the redemption coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("Specification")]
                    [Validation(Required=false)]
                    public string Specification { get; set; }

                    /// <summary>
                    /// <para>The status of the redemption coupon. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Generated</description></item>
                    /// <item><description>CallBack</description></item>
                    /// <item><description>RefundPending</description></item>
                    /// <item><description>Canceled</description></item>
                    /// <item><description>Order_Canceled</description></item>
                    /// <item><description>ActivePending</description></item>
                    /// <item><description>ActiveSuccess</description></item>
                    /// <item><description>ExchangePending</description></item>
                    /// <item><description>ExchangeSuccess</description></item>
                    /// <item><description>Expired</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Generated</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
