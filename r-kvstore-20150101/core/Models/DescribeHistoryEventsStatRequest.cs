// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryEventsStatRequest : TeaModel {
        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Archived</b>: Archived.</description></item>
        /// <item><description><b>UnArchived</b>: Not archived.</description></item>
        /// <item><description><b>All</b>: All events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Archived</para>
        /// </summary>
        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for the task start time. Only tasks whose start time is later than this time are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0. The earliest supported time is 30 days before the current time. If the specified time is more than 30 days before the current time, it is automatically converted to 30 days before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The end of the time range for the task start time. Only tasks whose start time is earlier than this time are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
