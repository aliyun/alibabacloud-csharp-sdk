// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateSqlPatternCompareReportRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the second time window. The time is in the yyyy-MM-ddTHH:mmZ or yyyy-MM-ddTHH:mm:ssZ format and must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T01:00Z</para>
        /// </summary>
        [NameInMap("CompareEndTime")]
        [Validation(Required=false)]
        public string CompareEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the second time window. The time is in the yyyy-MM-ddTHH:mmZ or yyyy-MM-ddTHH:mm:ssZ format and must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T00:00Z</para>
        /// </summary>
        [NameInMap("CompareStartTime")]
        [Validation(Required=false)]
        public string CompareStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-2ze1234567890****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the first time window. The time is in the yyyy-MM-ddTHH:mmZ or yyyy-MM-ddTHH:mm:ssZ format and must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-07T01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The report type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>NEW</c>: SQL patterns added in the second time window</description></item>
        /// <item><description><c>CHANGED</c>: SQL patterns that exist in both time windows and have an increased average value in at least one dimension</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHANGED</para>
        /// </summary>
        [NameInMap("PatternType")]
        [Validation(Required=false)]
        public string PatternType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of the first time window. The time is in the yyyy-MM-ddTHH:mmZ or yyyy-MM-ddTHH:mm:ssZ format and must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-07T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
