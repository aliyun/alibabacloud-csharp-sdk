// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateOperationEventScheduleTimeRequest : TeaModel {
        /// <summary>
        /// <para>The event ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2034449120420339713</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The new scheduled time in <c>YYYY-MM-DD HH:mm:ss</c> format. The time zone is UTC+8.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-23 14:55:00</para>
        /// </summary>
        [NameInMap("scheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

    }

}
