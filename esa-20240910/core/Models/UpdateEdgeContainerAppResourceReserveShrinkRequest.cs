// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateEdgeContainerAppResourceReserveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be obtained by calling the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The end time of the reservation. The input time is UTC. It takes +8 hours to enter Beijing time. For example, if the current time is 2006-01-02 06:04:05, you need to enter &quot;2006-01-02T14:04:05Z&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006-01-02T15:04:05Z</para>
        /// </summary>
        [NameInMap("DurationTime")]
        [Validation(Required=false)]
        public string DurationTime { get; set; }

        /// <summary>
        /// <para>Whether to enable resource reservation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Whether to permanently enable the reservation. Once it is enabled, you are not allowed to set the reservation deadline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Forever")]
        [Validation(Required=false)]
        public bool? Forever { get; set; }

        /// <summary>
        /// <para>Reserved resource list.</para>
        /// </summary>
        [NameInMap("ReserveSet")]
        [Validation(Required=false)]
        public string ReserveSetShrink { get; set; }

    }

}
