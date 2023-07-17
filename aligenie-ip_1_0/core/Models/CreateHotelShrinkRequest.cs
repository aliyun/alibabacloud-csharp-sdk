// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelShrinkRequest : TeaModel {
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

        [NameInMap("HotelName")]
        [Validation(Required=false)]
        public string HotelName { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("RelatedPk")]
        [Validation(Required=false)]
        public string RelatedPk { get; set; }

        /// <summary>
        /// 酒店关联产品列表
        /// </summary>
        [NameInMap("RelatedPks")]
        [Validation(Required=false)]
        public string RelatedPksShrink { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RoomNum")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        [NameInMap("TbOpenId")]
        [Validation(Required=false)]
        public string TbOpenId { get; set; }

    }

}
