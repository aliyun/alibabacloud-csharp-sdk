// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelsRequest : TeaModel {
        [NameInMap("HotelRequest")]
        [Validation(Required=false)]
        public ListHotelsRequestHotelRequest HotelRequest { get; set; }
        public class ListHotelsRequestHotelRequest : TeaModel {
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListHotelsRequestPage Page { get; set; }
        public class ListHotelsRequestPage : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
