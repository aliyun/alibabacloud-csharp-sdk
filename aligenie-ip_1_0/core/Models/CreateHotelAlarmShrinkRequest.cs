// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelAlarmShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("MusicType")]
        [Validation(Required=false)]
        public string MusicType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rooms")]
        [Validation(Required=false)]
        public string RoomsShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleInfo")]
        [Validation(Required=false)]
        public string ScheduleInfoShrink { get; set; }

    }

}
