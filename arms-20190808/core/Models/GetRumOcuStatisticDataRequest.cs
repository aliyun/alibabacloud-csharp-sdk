// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumOcuStatisticDataRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687849260000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter condition. Three types of filter conditions are provided:</para>
        /// <list type="bullet">
        /// <item><description>Application name: pid (Note that the application name is displayed, but the application ID is actually specified)</description></item>
        /// <item><description>Application type: siteType</description></item>
        /// <item><description>Data type: dataType</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetRumOcuStatisticDataRequestFilter> Filter { get; set; }
        public class GetRumOcuStatisticDataRequestFilter : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. Three types of filter conditions are provided:</para>
            /// <list type="bullet">
            /// <item><description>Application name: pid (Note that the application name is displayed, but the application ID is actually specified)</description></item>
            /// <item><description>Application type: siteType</description></item>
            /// <item><description>Data type: dataType</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pid</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The type of the operator. Valid value: in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            /// <summary>
            /// <para>The value of the filter condition. The value is a JSON array of strings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;b590xxxxx@2dcbxxxxx9&quot;, &quot;b590xxxxx@2dcbxxxxx8&quot;]</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        /// <summary>
        /// <para>The grouping fields. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>siteType: The total number of OCUs is grouped by application type.</description></item>
        /// <item><description>dataType: The total number of OCUs is grouped by data type.</description></item>
        /// <item><description>pid: The total number of OCUs is grouped by application ID.</description></item>
        /// <item><description>appName: The total number of OCUs is grouped by application name.</description></item>
        /// <item><description>startTime: The total number of OCUs is grouped by start time.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public List<string> Group { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the query. To query non-time series data, set the value to INSTANT. To query time series data, set the value to TIME_SERIES.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TIME_SERIES</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1600063200000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
