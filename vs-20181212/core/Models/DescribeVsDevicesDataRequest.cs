// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDevicesDataRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the data to retrieve. The end time must be later than the start time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>The minimum data granularity is 5 minutes.</description></item>
        /// <item><description>If you do not specify this parameter, the data of the last 24 hours is retrieved by default.</description></item>
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
        /// <para>The workspace ID.</para>
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
        /// <para>The start time of the data to retrieve.    </para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>The minimum data granularity is 5 minutes.</description></item>
        /// <item><description>If you do not specify this parameter, the data of the last 24 hours is retrieved by default.</description></item>
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
