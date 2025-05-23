// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelSettingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>af7***536</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SCREENSAVER</para>
        /// </summary>
        [NameInMap("SettingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

    }

}
