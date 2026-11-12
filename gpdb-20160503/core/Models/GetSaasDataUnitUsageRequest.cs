// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSaasDataUnitUsageRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query in UTC. The format is yyyy-MM-ddTHH:mm:ssZ, and the seconds must be 00. The end time must be later than the start time and no later than the request time. The query range is not automatically truncated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-20T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the undeleted SaaS service. A standard DBInstanceId cannot override it.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agdb-example</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The start time of the query in UTC. The format is yyyy-MM-ddTHH:mm:ssZ, and the seconds must be 00. The start time cannot be earlier than 30 days before the request time. The start time and the end time form a left-closed and right-open interval, and the span cannot exceed 7 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Specifies the time granularity. Valid values: hour (UTC hour) and day (UTC day). Default value: hour. This parameter only determines the trend aggregation method and is not returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hour</para>
        /// </summary>
        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

    }

}
