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

        /// <summary>
        /// <b>Example:</b>
        /// <para>a7a3***013</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("HotelScreenSaver")]
        [Validation(Required=false)]
        public AddOrUpdateHotelSettingRequestHotelScreenSaver HotelScreenSaver { get; set; }
        public class AddOrUpdateHotelSettingRequestHotelScreenSaver : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://a****jpg">https://a****jpg</a></para>
            /// </summary>
            [NameInMap("ScreenSaverPicUrl")]
            [Validation(Required=false)]
            public string ScreenSaverPicUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>common-weather</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22:00</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>screenoff</para>
            /// </summary>
            [NameInMap("StandbyAction")]
            [Validation(Required=false)]
            public string StandbyAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7:00</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SCREENSAVER</para>
        /// </summary>
        [NameInMap("SettingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
