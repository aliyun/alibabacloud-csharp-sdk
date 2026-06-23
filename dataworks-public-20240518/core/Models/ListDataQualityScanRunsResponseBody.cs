// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityScanRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityScanRunsResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityScanRunsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The list of data quality scan runs.</para>
            /// </summary>
            [NameInMap("DataQualityScanRuns")]
            [Validation(Required=false)]
            public List<ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRuns> DataQualityScanRuns { get; set; }
            public class ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRuns : TeaModel {
                /// <summary>
                /// <para>The start time of the data quality scan run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The end time of the data quality scan run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the data quality scan run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3155</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The parameters used for the run.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRunsParameters> Parameters { get; set; }
                public class ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRunsParameters : TeaModel {
                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dt</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The parameter value. You can use a scheduling time expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$[yyyy-mm-dd-1]</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The status of the data quality scan run. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pass</para>
                /// </description></item>
                /// <item><description><para>Running</para>
                /// </description></item>
                /// <item><description><para>Error</para>
                /// </description></item>
                /// <item><description><para>Warn</para>
                /// </description></item>
                /// <item><description><para>Fail</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Fail</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The page number. The default value is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. The default value is 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>324</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
