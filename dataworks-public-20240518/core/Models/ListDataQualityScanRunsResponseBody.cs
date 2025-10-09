// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityScanRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityScanRunsResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityScanRunsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The list of data quality monitor run records.</para>
            /// </summary>
            [NameInMap("DataQualityScanRuns")]
            [Validation(Required=false)]
            public List<ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRuns> DataQualityScanRuns { get; set; }
            public class ListDataQualityScanRunsResponseBodyPageInfoDataQualityScanRuns : TeaModel {
                /// <summary>
                /// <para>The time when the data quality monitor starts running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the data quality monitor stops.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the data quality monitor running record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3155</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The parameters configured for the instance.</para>
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
                /// <para>The status of the instance.</para>
                /// <list type="bullet">
                /// <item><description>Pass</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Error</description></item>
                /// <item><description>Warn</description></item>
                /// <item><description>Fail</description></item>
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
            /// <para>The page number of the results. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records returned.</para>
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
