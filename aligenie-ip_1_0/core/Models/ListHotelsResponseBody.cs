// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelsResponseBody : TeaModel {
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

        /// <summary>
        /// <para>RequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListHotelsResponseBodyResult Result { get; set; }
        public class ListHotelsResponseBodyResult : TeaModel {
            [NameInMap("HotelInfoList")]
            [Validation(Required=false)]
            public List<ListHotelsResponseBodyResultHotelInfoList> HotelInfoList { get; set; }
            public class ListHotelsResponseBodyResultHotelInfoList : TeaModel {
                [NameInMap("AccountNames")]
                [Validation(Required=false)]
                public List<string> AccountNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1654568802000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>酒店地址</para>
                /// </summary>
                [NameInMap("HotelAddress")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>73ab1b03018d4da69b5bef17095f569b</para>
                /// </summary>
                [NameInMap("HotelId")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>酒店名称</para>
                /// </summary>
                [NameInMap("HotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>酒店</para>
                /// </summary>
                [NameInMap("IndustryType")]
                [Validation(Required=false)]
                public string IndustryType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13312340987</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试产品</para>
                /// </summary>
                [NameInMap("RelatedProductName")]
                [Validation(Required=false)]
                public string RelatedProductName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("RoomNum")]
                [Validation(Required=false)]
                public int? RoomNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListHotelsResponseBodyResultPage Page { get; set; }
            public class ListHotelsResponseBodyResultPage : TeaModel {
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
                /// <para>23</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalPage")]
                [Validation(Required=false)]
                public int? TotalPage { get; set; }

            }

        }

    }

}
