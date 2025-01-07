// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOperationProcessDetailResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOperationProcessDetailResponseBodyPageInfo PageInfo { get; set; }
        public class ListOperationProcessDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ProcessDetails")]
        [Validation(Required=false)]
        public List<ListOperationProcessDetailResponseBodyProcessDetails> ProcessDetails { get; set; }
        public class ListOperationProcessDetailResponseBodyProcessDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetVendor")]
            [Validation(Required=false)]
            public int? AssetVendor { get; set; }

            [NameInMap("Checks")]
            [Validation(Required=false)]
            public List<ListOperationProcessDetailResponseBodyProcessDetailsChecks> Checks { get; set; }
            public class ListOperationProcessDetailResponseBodyProcessDetailsChecks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>133</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public long? CheckId { get; set; }

                [NameInMap("CheckShowName")]
                [Validation(Required=false)]
                public string CheckShowName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1706544199000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fb4bcd41-a916-46bc-ab1a-65fd383be***</para>
            /// </summary>
            [NameInMap("DetailTaskId")]
            [Validation(Required=false)]
            public string DetailTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1706544199000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1730335622000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v34578b8-e567-47ec-2345-3e5b077ca***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F3***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
