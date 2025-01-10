// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddOrUpdateScreenSaverRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7a3***013</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HotelScreenSaver")]
        [Validation(Required=false)]
        public AddOrUpdateScreenSaverRequestHotelScreenSaver HotelScreenSaver { get; set; }
        public class AddOrUpdateScreenSaverRequestHotelScreenSaver : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx.png</para>
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

    }

}
