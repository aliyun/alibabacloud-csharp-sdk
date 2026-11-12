// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHistoryEventsStatRequest : TeaModel {
        /// <summary>
        /// <para>The archive status of the events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Archived: The events are archived.</description></item>
        /// <item><description>UnArchived: The events are not archived.</description></item>
        /// <item><description>All: All events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// <para>The start time of the query time range for the task start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time must be in UTC. This parameter is required. If you do not specify this parameter, the service returns a Param.Invalid (400) error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the region where the events are located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The end time of the query time range for the task start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time must be in UTC. This parameter is required. If you do not specify this parameter, the service returns a Param.Invalid (400) error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-03T12:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
