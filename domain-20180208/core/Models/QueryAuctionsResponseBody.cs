// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryAuctionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAuctionsResponseBodyData> Data { get; set; }
        public class QueryAuctionsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1515961936000</para>
            /// </summary>
            [NameInMap("AuctionEndTime")]
            [Validation(Required=false)]
            public long? AuctionEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("AuctionId")]
            [Validation(Required=false)]
            public string AuctionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1515961936000</para>
            /// </summary>
            [NameInMap("BookEndTime")]
            [Validation(Required=false)]
            public long? BookEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("BookedPartner")]
            [Validation(Required=false)]
            public string BookedPartner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RMB</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1515961936000</para>
            /// </summary>
            [NameInMap("DeliveryTime")]
            [Validation(Required=false)]
            public long? DeliveryTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HighBid")]
            [Validation(Required=false)]
            public float? HighBid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("HighBidder")]
            [Validation(Required=false)]
            public string HighBidder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110</para>
            /// </summary>
            [NameInMap("NextValidBid")]
            [Validation(Required=false)]
            public float? NextValidBid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("PartnerType")]
            [Validation(Required=false)]
            public string PartnerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1515961936000</para>
            /// </summary>
            [NameInMap("PayEndTime")]
            [Validation(Required=false)]
            public long? PayEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("PayPrice")]
            [Validation(Required=false)]
            public float? PayPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayStatus")]
            [Validation(Required=false)]
            public string PayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProduceStatus")]
            [Validation(Required=false)]
            public string ProduceStatus { get; set; }

            [NameInMap("ReserveMax")]
            [Validation(Required=false)]
            public long? ReserveMax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReserveMet")]
            [Validation(Required=false)]
            public bool? ReserveMet { get; set; }

            [NameInMap("ReserveMin")]
            [Validation(Required=false)]
            public long? ReserveMin { get; set; }

            [NameInMap("ReservePrice")]
            [Validation(Required=false)]
            public long? ReservePrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TransferInPrice")]
            [Validation(Required=false)]
            public float? TransferInPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("YourCurrentBid")]
            [Validation(Required=false)]
            public float? YourCurrentBid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("YourMaxBid")]
            [Validation(Required=false)]
            public float? YourMaxBid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
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
