// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterInspectReportDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The results.</para>
        /// </summary>
        [NameInMap("checkItemResults")]
        [Validation(Required=false)]
        public List<GetClusterInspectReportDetailResponseBodyCheckItemResults> CheckItemResults { get; set; }
        public class GetClusterInspectReportDetailResponseBodyCheckItemResults : TeaModel {
            /// <summary>
            /// <para>The category of the inspection item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>security: Security compliance</description></item>
            /// <item><description>performance: Performance efficiency</description></item>
            /// <item><description>stability: Business stability</description></item>
            /// <item><description>limitation: Service limits</description></item>
            /// <item><description>cost: Cost optimization</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>stability</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The unique identifier of the inspection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>APIServerClbInstanceStatus</para>
            /// </summary>
            [NameInMap("checkItemUid")]
            [Validation(Required=false)]
            public string CheckItemUid { get; set; }

            /// <summary>
            /// <para>The description of the inspection item.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The fixing suggestion.</para>
            /// </summary>
            [NameInMap("fix")]
            [Validation(Required=false)]
            public string Fix { get; set; }

            /// <summary>
            /// <para>The level of the inspection item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>advice: Suggestions</description></item>
            /// <item><description>warning: Low severity</description></item>
            /// <item><description>error: Medium severity</description></item>
            /// <item><description>critical: High severity</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>critical</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The name of the inspection item.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The inspection results. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The inspection item is abnormal.</description></item>
            /// <item><description>false: The inspection item is normal.</description></item>
            /// <item><description>disable: The inspection item is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The resource type of the inspection object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLB</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The inspection objects.</para>
            /// </summary>
            [NameInMap("targets")]
            [Validation(Required=false)]
            public List<string> Targets { get; set; }

        }

        /// <summary>
        /// <para>The completion time of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-18T19:41:12.778433+08:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The token that is used to display the returned tags on multiple pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AK8uQQrxgFK8sbARvnCj6w9R3kPme4I3</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>782df89346054a0000562063a****</para>
        /// </summary>
        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49511F2D-D56A-5C24-B9AE-C8491E09B***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the inspection report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-18T19:40:16.778333+08:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the inspection report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>completed: The inspection report is generated.</description></item>
        /// <item><description>running: The inspection report is generating.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Overview of inspection reports.</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public GetClusterInspectReportDetailResponseBodySummary Summary { get; set; }
        public class GetClusterInspectReportDetailResponseBodySummary : TeaModel {
            /// <summary>
            /// <para>The number of check items whose inspection result is advice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("adviceCount")]
            [Validation(Required=false)]
            public int? AdviceCount { get; set; }

            /// <summary>
            /// <para>Check the status code of the inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>warning</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The number of check items whose inspection result is error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public int? ErrorCount { get; set; }

            /// <summary>
            /// <para>The number of check items whose inspection result is normal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("normalCount")]
            [Validation(Required=false)]
            public int? NormalCount { get; set; }

            /// <summary>
            /// <para>The number of check items whose inspection result is warning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("warnCount")]
            [Validation(Required=false)]
            public int? WarnCount { get; set; }

        }

    }

}
