// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddOrUpdateHotelSettingShrinkRequest : TeaModel {
        [NameInMap("HotelDeviceModeList")]
        [Validation(Required=false)]
        public string HotelDeviceModeListShrink { get; set; }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("HotelScreenSaver")]
        [Validation(Required=false)]
        public string HotelScreenSaverShrink { get; set; }

        [NameInMap("NightMode")]
        [Validation(Required=false)]
        public string NightModeShrink { get; set; }

        [NameInMap("SettingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
