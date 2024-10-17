// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryBrokerDemandResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryBrokerDemandResponseBodyData> Data { get; set; }
        public class QueryBrokerDemandResponseBodyData : TeaModel {
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13300000001</para>
            /// </summary>
            [NameInMap("BargainSellerMobile")]
            [Validation(Required=false)]
            public string BargainSellerMobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BargainSellerPrice")]
            [Validation(Required=false)]
            public float? BargainSellerPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SE20183915FI0178</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>taobao.com</para>
            /// </summary>
            [NameInMap("DemandDomain")]
            [Validation(Required=false)]
            public string DemandDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DemandPrice")]
            [Validation(Required=false)]
            public float? DemandPrice { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13300000000</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            [NameInMap("PartnerDomain")]
            [Validation(Required=false)]
            public string PartnerDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("PayDomain")]
            [Validation(Required=false)]
            public string PayDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PayPrice")]
            [Validation(Required=false)]
            public float? PayPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1524800053000</para>
            /// </summary>
            [NameInMap("PayTime")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProduceType")]
            [Validation(Required=false)]
            public int? ProduceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1524800053000</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public long? PublishTime { get; set; }

            [NameInMap("PurchaseStatus")]
            [Validation(Required=false)]
            public int? PurchaseStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18800</para>
            /// </summary>
            [NameInMap("ServicePayPrice")]
            [Validation(Required=false)]
            public float? ServicePayPrice { get; set; }

            [NameInMap("SettleBasePrice")]
            [Validation(Required=false)]
            public float? SettleBasePrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>497F7522-82B0-4BD4-84FE-AE8749E4C2F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
