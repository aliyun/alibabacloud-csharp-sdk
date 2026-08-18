// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetInspectionReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The result details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetInspectionReportResponseBodyData> Data { get; set; }
        public class GetInspectionReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The request result.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetInspectionReportResponseBodyDataData> Data { get; set; }
            public class GetInspectionReportResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_info</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The attached resource names.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetInspectionReportResponseBodyDataDataItems> Items { get; set; }
                public class GetInspectionReportResponseBodyDataDataItems : TeaModel {
                    /// <summary>
                    /// <para>The request result.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<GetInspectionReportResponseBodyDataDataItemsData> Data { get; set; }
                    public class GetInspectionReportResponseBodyDataDataItemsData : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DBInstanceStatus</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Running</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The alert level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The result message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Instance running status is normal</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instance_runningstatus</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The inspection end time in the format of YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-31T02:05:04Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The instance description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test instance</para>
            /// </summary>
            [NameInMap("InstanceDesc")]
            [Validation(Required=false)]
            public string InstanceDesc { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2zep6e5u6l2yu****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The level summary.</para>
            /// </summary>
            [NameInMap("LevelSummary")]
            [Validation(Required=false)]
            public GetInspectionReportResponseBodyDataLevelSummary LevelSummary { get; set; }
            public class GetInspectionReportResponseBodyDataLevelSummary : TeaModel {
                /// <summary>
                /// <para>The number of error items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public long? Error { get; set; }

                /// <summary>
                /// <para>The number of failed items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                /// <summary>
                /// <para>The number of normal items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Normal")]
                [Validation(Required=false)]
                public long? Normal { get; set; }

                /// <summary>
                /// <para>The number of warning items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Warning")]
                [Validation(Required=false)]
                public long? Warning { get; set; }

            }

            /// <summary>
            /// <para>The Markdown text.</para>
            /// <list type="bullet">
            /// <item><description>If the InstanceId parameter is not specified: the reports for all instances under this inspection report are returned, but the MarkdownText field is empty (&quot;&quot;).</description></item>
            /// <item><description>If the InstanceId parameter is specified: the report for the specified instance is returned, and the MarkdownText field contains the specific content.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <h1>RDS Instance Inspection Report\n\n<b>Instance ID</b>: <c>rm-2zep6e5u6l2yu****</c>\n\n<b>Engine Type</b>: MySQL\n\n<b>Region</b>: cn-beijing\n\n<b>Time Range (UTC)</b>: 2026-02-04T03:31:00Z ~ 2026-02-05T03:31:00Z\n\n&gt; This inspection includes <b>60</b> check items, of which 1 warning, 57 normal, and 2 failed to retrieve data.……</h1>
            /// </summary>
            [NameInMap("MarkdownText")]
            [Validation(Required=false)]
            public string MarkdownText { get; set; }

            /// <summary>
            /// <para>The region information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The inspection start time in the format of YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-06T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The Markdown text.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>RDS Batch Inspection Summary Report\n\n&gt; This batch inspection checked <b>1</b> instance; found <b>1</b> instance with warnings (1 warning item in total)……</h1>
        /// </summary>
        [NameInMap("MarkdownText")]
        [Validation(Required=false)]
        public string MarkdownText { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The inspection report ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9d246af2-a0cd-4f69-857d-3785048f****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
