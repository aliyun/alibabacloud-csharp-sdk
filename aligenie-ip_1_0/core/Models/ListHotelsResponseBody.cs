// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// RequestId
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

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("HotelAddress")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                [NameInMap("HotelId")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("HotelName")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("IndustryType")]
                [Validation(Required=false)]
                public string IndustryType { get; set; }

                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("RelatedProductName")]
                [Validation(Required=false)]
                public string RelatedProductName { get; set; }

                [NameInMap("RoomNum")]
                [Validation(Required=false)]
                public int? RoomNum { get; set; }

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

                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                [NameInMap("TotalPage")]
                [Validation(Required=false)]
                public int? TotalPage { get; set; }

            }

        }

    }

}
