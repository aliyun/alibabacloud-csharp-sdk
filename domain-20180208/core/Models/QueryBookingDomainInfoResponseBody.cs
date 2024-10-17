// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryBookingDomainInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("AuctionId")]
        [Validation(Required=false)]
        public int? AuctionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1517985730419</para>
        /// </summary>
        [NameInMap("BookEndTime")]
        [Validation(Required=false)]
        public long? BookEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USD</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("MaxBid")]
        [Validation(Required=false)]
        public float? MaxBid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("PartnerType")]
        [Validation(Required=false)]
        public string PartnerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>234234njhjkhkj</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnatchNo")]
        [Validation(Required=false)]
        public string SnatchNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("TransferInPrice")]
        [Validation(Required=false)]
        public float? TransferInPrice { get; set; }

    }

}
