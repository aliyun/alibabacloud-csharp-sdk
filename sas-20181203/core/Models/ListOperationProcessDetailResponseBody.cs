// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationProcessDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOperationProcessDetailResponseBodyPageInfo PageInfo { get; set; }
        public class ListOperationProcessDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The information about the operation subtasks.</para>
        /// </summary>
        [NameInMap("ProcessDetails")]
        [Validation(Required=false)]
        public List<ListOperationProcessDetailResponseBodyProcessDetails> ProcessDetails { get; set; }
        public class ListOperationProcessDetailResponseBodyProcessDetails : TeaModel {
            /// <summary>
            /// <para>The subtype of the asset associated with the operation subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of the asset associated with the operation subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The vendor of the asset associated with the operation subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetVendor")]
            [Validation(Required=false)]
            public int? AssetVendor { get; set; }

            /// <summary>
            /// <para>The check items associated with the operation subtask.</para>
            /// </summary>
            [NameInMap("Checks")]
            [Validation(Required=false)]
            public List<ListOperationProcessDetailResponseBodyProcessDetailsChecks> Checks { get; set; }
            public class ListOperationProcessDetailResponseBodyProcessDetailsChecks : TeaModel {
                /// <summary>
                /// <para>The ID of the check item associated with the operation subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>133</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                /// <summary>
                /// <para>The name of the check item associated with the operation subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Check for Security Center Agent Status</para>
                /// </summary>
                [NameInMap("CheckShowName")]
                [Validation(Required=false)]
                public string CheckShowName { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the task was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706544199000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the operation subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fb4bcd41-a916-46bc-ab1a-65fd383be***</para>
            /// </summary>
            [NameInMap("DetailTaskId")]
            [Validation(Required=false)]
            public string DetailTaskId { get; set; }

            /// <summary>
            /// <para>The end timestamp of the operation subtask. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706544199000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start timestamp of the operation subtask. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1730335622000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The subtask status code. Enumerated values:</para>
            /// <list type="bullet">
            /// <item><description>0: not started.</description></item>
            /// <item><description>1: running.</description></item>
            /// <item><description>2: successful.</description></item>
            /// <item><description>3: times out.</description></item>
            /// <item><description>4: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <para>The ID of the operation subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v34578b8-e567-47ec-2345-3e5b077ca***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F3***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
