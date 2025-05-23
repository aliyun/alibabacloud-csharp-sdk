// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateClusterInspectConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of disabled inspection check items.</para>
        /// </summary>
        [NameInMap("disabledCheckItems")]
        [Validation(Required=false)]
        public List<string> DisabledCheckItems { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cluster inspection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The inspection period defined using RFC5545 Recurrence Rule. You must specify BYHOUR and BYMINUTE. Only FREQ=DAILY is supported. COUNT or UNTIL is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREQ=DAILY;BYHOUR=10;BYMINUTE=15</para>
        /// </summary>
        [NameInMap("scheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

    }

}
