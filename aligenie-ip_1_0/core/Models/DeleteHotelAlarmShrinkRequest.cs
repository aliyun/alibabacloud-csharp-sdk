// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class DeleteHotelAlarmShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public string AlarmsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7***83</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

    }

}
