// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelSettingResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetHotelSettingResponseBodyResult Result { get; set; }
        public class GetHotelSettingResponseBodyResult : TeaModel {
            [NameInMap("DeleteToken")]
            [Validation(Required=false)]
            public long? DeleteToken { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("HotelDeviceModeList")]
            [Validation(Required=false)]
            public List<string> HotelDeviceModeList { get; set; }

            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("HotelScreenSaver")]
            [Validation(Required=false)]
            public GetHotelSettingResponseBodyResultHotelScreenSaver HotelScreenSaver { get; set; }
            public class GetHotelSettingResponseBodyResultHotelScreenSaver : TeaModel {
                [NameInMap("ScreenSaverPicUrl")]
                [Validation(Required=false)]
                public string ScreenSaverPicUrl { get; set; }

                [NameInMap("ScreenSaverStyle")]
                [Validation(Required=false)]
                public string ScreenSaverStyle { get; set; }

            }

            [NameInMap("NightMode")]
            [Validation(Required=false)]
            public GetHotelSettingResponseBodyResultNightMode NightMode { get; set; }
            public class GetHotelSettingResponseBodyResultNightMode : TeaModel {
                /// <summary>
                /// 夜间模式下的默认亮度
                /// </summary>
                [NameInMap("DefaultBright")]
                [Validation(Required=false)]
                public string DefaultBright { get; set; }

                /// <summary>
                /// 夜间模式下的默认音量
                /// </summary>
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

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
