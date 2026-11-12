// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSaasDataUnitUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The business distribution. The items are sorted in descending order of DataUnit. Items with unknown amounts are placed at the end. Items with the same value are sorted in ascending order of scenario code, project ID, and name. The items are grouped by scenario and project ID. Items without an ID but with a name are grouped by name. Records missing both are grouped as unassociated projects. The sum of all items in the complete result equals the summary. Missing or blank log scenarios are classified as other. Scenarios with values but no configured mapping retain the original values as codes and display names, and are normally included in the total. No empty rows are created for other if there are no records.</para>
        /// </summary>
        [NameInMap("Distribution")]
        [Validation(Required=false)]
        public List<GetSaasDataUnitUsageResponseBodyDistribution> Distribution { get; set; }
        public class GetSaasDataUnitUsageResponseBodyDistribution : TeaModel {
            /// <summary>
            /// <para>The exact non-negative decimal string. Floating-point or exponential formats are not used. The value is null when the amount is incomplete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.82</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DataUnit")]
            [Validation(Required=false)]
            public string DataUnit { get; set; }

            /// <summary>
            /// <para>The project attribution at the time of the call. The value is null when missing, which does not affect the total amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project-1</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The project name. For the same scenario and project ID, the latest non-empty name snapshot within the query range is used. If multiple snapshots exist in the same second, the maximum value in lexicographical order is used. The value is null when missing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scenario remake</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The business scenario code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drama_game_oneshot</para>
            /// </summary>
            [NameInMap("UsageScene")]
            [Validation(Required=false)]
            public string UsageScene { get; set; }

            /// <summary>
            /// <para>The display name of the business scenario. This name is supplemented by a dictionary that maps the original Meta values to Chinese names, and is not an SLS field. UsageScene always retains the original log value. If no Chinese name is available, the original value is used as the name. Blank values are classified as other. Different codes with the same Chinese name are not merged.</para>
            /// 
            /// <b>Example:</b>
            /// <para>游戏生成</para>
            /// </summary>
            [NameInMap("UsageSceneName")]
            [Validation(Required=false)]
            public string UsageSceneName { get; set; }

        }

        /// <summary>
        /// <para>The actual end time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-20T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mock_req_success</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SaaS service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agdb-example</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The actual start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The usage summary.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public GetSaasDataUnitUsageResponseBodySummary Summary { get; set; }
        public class GetSaasDataUnitUsageResponseBodySummary : TeaModel {
            /// <summary>
            /// <para>The exact non-negative decimal string. Floating-point or exponential formats are not used. The value is null when the amount is incomplete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.82</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DataUnit")]
            [Validation(Required=false)]
            public string DataUnit { get; set; }

        }

        /// <summary>
        /// <para>The time trend. The items are sorted in ascending order of the UTC bucket start time. Zero buckets are padded for complete queries. The value is null for unknown amounts and is not replaced with zero.</para>
        /// </summary>
        [NameInMap("TimeSeries")]
        [Validation(Required=false)]
        public List<GetSaasDataUnitUsageResponseBodyTimeSeries> TimeSeries { get; set; }
        public class GetSaasDataUnitUsageResponseBodyTimeSeries : TeaModel {
            /// <summary>
            /// <para>The exact non-negative decimal string. Floating-point or exponential formats are not used. The value is null when the amount is incomplete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.82</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DataUnit")]
            [Validation(Required=false)]
            public string DataUnit { get; set; }

            /// <summary>
            /// <para>The scenario usage within the bucket.</para>
            /// </summary>
            [NameInMap("Scenes")]
            [Validation(Required=false)]
            public List<GetSaasDataUnitUsageResponseBodyTimeSeriesScenes> Scenes { get; set; }
            public class GetSaasDataUnitUsageResponseBodyTimeSeriesScenes : TeaModel {
                /// <summary>
                /// <para>The exact non-negative decimal string. Floating-point or exponential formats are not used. The value is null when the amount is incomplete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.82</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("DataUnit")]
                [Validation(Required=false)]
                public string DataUnit { get; set; }

                /// <summary>
                /// <para>The project attribution at the time of the call. The value is null when missing, which does not affect the total amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project-1</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                /// <summary>
                /// <para>The project name. For the same scenario and project ID, the latest non-empty name snapshot within the query range is used. If multiple snapshots exist in the same second, the maximum value in lexicographical order is used. The value is null when missing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scenario remake</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The business scenario code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>game_translation</para>
                /// </summary>
                [NameInMap("UsageScene")]
                [Validation(Required=false)]
                public string UsageScene { get; set; }

            }

            /// <summary>
            /// <para>The start time of the UTC bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// <para>The product notifications.</para>
        /// </summary>
        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public List<GetSaasDataUnitUsageResponseBodyWarnings> Warnings { get; set; }
        public class GetSaasDataUnitUsageResponseBodyWarnings : TeaModel {
            /// <summary>
            /// <para>The notification code. Valid values include DATA_INCOMPLETE and DATA_UNIT_PENDING.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_INCOMPLETE</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The notification message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Partial usage is not ready yet</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
