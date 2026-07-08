// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDevicesDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The date must follow the ISO 8601 standard and be in UTC. The format is YYYY-MM-DDThh:mm:ssZ.</para>
        /// </description></item>
        /// <item><description><para>The minimum data granularity is 5 minutes.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, data from the last 24 hours is retrieved by default.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>You can query by space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****174-cn-qingdao</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The date must follow the ISO 8601 standard and be in UTC. The format is YYYY-MM-DDThh:mm:ssZ.</para>
        /// </description></item>
        /// <item><description><para>The minimum data granularity is 5 minutes.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, data from the last 24 hours is retrieved by default.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-04T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
