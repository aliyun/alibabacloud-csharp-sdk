// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("EstOpenTime")]
        [Validation(Required=false)]
        public string EstOpenTime { get; set; }

        [NameInMap("HotelAddress")]
        [Validation(Required=false)]
        public string HotelAddress { get; set; }

        [NameInMap("HotelEmail")]
        [Validation(Required=false)]
        public string HotelEmail { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("HotelName")]
        [Validation(Required=false)]
        public string HotelName { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("RelatedPks")]
        [Validation(Required=false)]
        public List<string> RelatedPks { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RoomNum")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TbOpenId")]
        [Validation(Required=false)]
        public string TbOpenId { get; set; }

    }

}
