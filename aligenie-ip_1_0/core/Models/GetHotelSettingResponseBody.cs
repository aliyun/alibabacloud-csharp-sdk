// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelSettingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7E2****B7C94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetHotelSettingResponseBodyResult Result { get; set; }
        public class GetHotelSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeleteToken")]
            [Validation(Required=false)]
            public long? DeleteToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("HotelDeviceModeList")]
            [Validation(Required=false)]
            public List<string> HotelDeviceModeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>af7***536</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("HotelScreenSaver")]
            [Validation(Required=false)]
            public GetHotelSettingResponseBodyResultHotelScreenSaver HotelScreenSaver { get; set; }
            public class GetHotelSettingResponseBodyResultHotelScreenSaver : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://a***png">https://a***png</a></para>
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
            public GetHotelSettingResponseBodyResultNightMode NightMode { get; set; }
            public class GetHotelSettingResponseBodyResultNightMode : TeaModel {
                /// <summary>
                /// <para>夜间模式下的默认亮度</para>
                /// </summary>
                [NameInMap("DefaultBright")]
                [Validation(Required=false)]
                public string DefaultBright { get; set; }

                /// <summary>
                /// <para>夜间模式下的默认音量</para>
                /// </summary>
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
                /// <para>07:00</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
