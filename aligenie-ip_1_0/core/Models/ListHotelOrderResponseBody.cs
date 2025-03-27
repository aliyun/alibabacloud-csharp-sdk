// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListHotelOrderResponseBodyPage Page { get; set; }
        public class ListHotelOrderResponseBodyPage : TeaModel {
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>07F61FDA-606F-10A0-8ED0-C6CE62710A48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListHotelOrderResponseBodyResult> Result { get; set; }
        public class ListHotelOrderResponseBodyResult : TeaModel {
            [NameInMap("Amt")]
            [Validation(Required=false)]
            public long? Amt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21.5</para>
            /// </summary>
            [NameInMap("ApplyAmt")]
            [Validation(Required=false)]
            public long? ApplyAmt { get; set; }

            [NameInMap("DeliveryMethod")]
            [Validation(Required=false)]
            public string DeliveryMethod { get; set; }

            [NameInMap("DeliveryRoomName")]
            [Validation(Required=false)]
            public string DeliveryRoomName { get; set; }

            [NameInMap("DeliveryTime")]
            [Validation(Required=false)]
            public long? DeliveryTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1659952892000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20220808180132000114508555527711</para>
            /// </summary>
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            [NameInMap("PaymentMethod")]
            [Validation(Required=false)]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SumAmt")]
            [Validation(Required=false)]
            public long? SumAmt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>REPAIR</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/changjingfenlei/shebeiweixiu.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/changjingfenlei/shebeiweixiu.png</a></para>
            /// </summary>
            [NameInMap("TypeIconUrl")]
            [Validation(Required=false)]
            public string TypeIconUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>设备维修</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
