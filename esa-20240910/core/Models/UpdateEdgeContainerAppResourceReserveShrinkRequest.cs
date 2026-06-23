// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateEdgeContainerAppResourceReserveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID.</para>
        /// <remarks>
        /// <para>Notice: The AppId format is the app- prefix followed by a numeric suffix, with a total length of 20 to 64 characters (example: app-8806886***83794688). Call ListEdgeContainerApps to obtain an existing AppId, or call CreateEdgeContainerApp to create an application first.</notice>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The reservation end time. This parameter uses UTC time. To convert from UTC+8, add 8 hours. For example, if the current time is 2006-01-02 06:04:05 in UTC+8, enter &quot;2006-01-02T14:04:05Z&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02T15:04:05Z</para>
        /// </summary>
        [NameInMap("DurationTime")]
        [Validation(Required=false)]
        public string DurationTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable resource reservation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Specifies whether to permanently enable reservation. Once enabled, you cannot set a reservation end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Forever")]
        [Validation(Required=false)]
        public bool? Forever { get; set; }

        /// <summary>
        /// <para>The list of reserved resources.</para>
        /// </summary>
        [NameInMap("ReserveSet")]
        [Validation(Required=false)]
        public string ReserveSetShrink { get; set; }

    }

}
