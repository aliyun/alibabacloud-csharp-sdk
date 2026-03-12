// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetInspectionReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetInspectionReportResponseBodyData> Data { get; set; }
        public class GetInspectionReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned results.</para>
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
                /// <para>The items in the result.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetInspectionReportResponseBodyDataDataItems> Items { get; set; }
                public class GetInspectionReportResponseBodyDataDataItems : TeaModel {
                    /// <summary>
                    /// <para>The returned results.</para>
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
                    /// <para>The level of the alert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The response message.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The name of the category.</para>
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
            /// <para>The end time of the inspection. Specify the time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
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
            /// <para>The description of the instance.</para>
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
            /// <para>The hierarchical summary of the report.</para>
            /// </summary>
            [NameInMap("LevelSummary")]
            [Validation(Required=false)]
            public GetInspectionReportResponseBodyDataLevelSummary LevelSummary { get; set; }
            public class GetInspectionReportResponseBodyDataLevelSummary : TeaModel {
                /// <summary>
                /// <para>The number of errors in the report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public long? Error { get; set; }

                /// <summary>
                /// <para>The number of failures in the report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                /// <summary>
                /// <para>The number of normal records in the report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Normal")]
                [Validation(Required=false)]
                public long? Normal { get; set; }

                /// <summary>
                /// <para>The number of warnings in the report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Warning")]
                [Validation(Required=false)]
                public long? Warning { get; set; }

            }

            /// <summary>
            /// <para>The report text in the markdown format.</para>
            /// <list type="bullet">
            /// <item><description>If the InstanceId parameter is not specified, all content of the inspection report is returned. However, the MarkdownText field is empty.</description></item>
            /// <item><description>If the InstanceId parameter is specified, the content related to the instance is returned in the MarkdownText field.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("MarkdownText")]
            [Validation(Required=false)]
            public string MarkdownText { get; set; }

            /// <summary>
            /// <para>The region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The start time of the inspection task. Specify the time in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-06T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The report text in the markdown format.</para>
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

    }

}
