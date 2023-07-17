// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelAlarmShrinkRequest : TeaModel {
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("MusicType")]
        [Validation(Required=false)]
        public string MusicType { get; set; }

        [NameInMap("Rooms")]
        [Validation(Required=false)]
        public string RoomsShrink { get; set; }

        [NameInMap("ScheduleInfo")]
        [Validation(Required=false)]
        public string ScheduleInfoShrink { get; set; }

    }

}
