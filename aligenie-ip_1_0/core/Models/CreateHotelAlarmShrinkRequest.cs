// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelAlarmShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf2446fc9d144c85aaee4f9ae20a96e7</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DOU_YIN</para>
        /// </summary>
        [NameInMap("MusicType")]
        [Validation(Required=false)]
        public string MusicType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rooms")]
        [Validation(Required=false)]
        public string RoomsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScheduleInfo")]
        [Validation(Required=false)]
        public string ScheduleInfoShrink { get; set; }

    }

}
