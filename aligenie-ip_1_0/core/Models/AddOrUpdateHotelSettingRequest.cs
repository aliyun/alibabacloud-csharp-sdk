// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddOrUpdateHotelSettingRequest : TeaModel {
        [NameInMap("HotelDeviceModeList")]
        [Validation(Required=false)]
        public List<string> HotelDeviceModeList { get; set; }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("HotelScreenSaver")]
        [Validation(Required=false)]
        public AddOrUpdateHotelSettingRequestHotelScreenSaver HotelScreenSaver { get; set; }
        public class AddOrUpdateHotelSettingRequestHotelScreenSaver : TeaModel {
            [NameInMap("ScreenSaverPicUrl")]
            [Validation(Required=false)]
            public string ScreenSaverPicUrl { get; set; }

            [NameInMap("ScreenSaverStyle")]
            [Validation(Required=false)]
            public string ScreenSaverStyle { get; set; }

        }

        [NameInMap("NightMode")]
        [Validation(Required=false)]
        public AddOrUpdateHotelSettingRequestNightMode NightMode { get; set; }
        public class AddOrUpdateHotelSettingRequestNightMode : TeaModel {
            [NameInMap("DefaultBright")]
            [Validation(Required=false)]
            public string DefaultBright { get; set; }

            [NameInMap("DefaultVolume")]
            [Validation(Required=false)]
            public string DefaultVolume { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("StandbyAction")]
            [Validation(Required=false)]
            public string StandbyAction { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("SettingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
