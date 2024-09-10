// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EstOpenTime")]
        [Validation(Required=false)]
        public string EstOpenTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelAddress")]
        [Validation(Required=false)]
        public string HotelAddress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelEmail")]
        [Validation(Required=false)]
        public string HotelEmail { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelName")]
        [Validation(Required=false)]
        public string HotelName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RelatedPk")]
        [Validation(Required=false)]
        public string RelatedPk { get; set; }

        /// <summary>
        /// 酒店关联产品列表
        /// </summary>
        [NameInMap("RelatedPks")]
        [Validation(Required=false)]
        public List<string> RelatedPks { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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
