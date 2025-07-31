// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityScanRunsResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityScanRunsResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityScanRunsResponseBodyPageInfo : TeaModel {
            [NameInMap("DataQualityScanRuns")]
            [Validation(Required=false)]
            public List<ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRuns> DataQualityScanRuns { get; set; }
            public class ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRuns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3155</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRunsParameters> Parameters { get; set; }
                public class ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRunsParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dt</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>$[yyyy-mm-dd-1]</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Fail</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>324</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
