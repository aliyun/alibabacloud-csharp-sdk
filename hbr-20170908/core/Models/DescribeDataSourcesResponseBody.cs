// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data sources.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<DescribeDataSourcesResponseBodyDataSources> DataSources { get; set; }
        public class DescribeDataSourcesResponseBodyDataSources : TeaModel {
            /// <summary>
            /// <para>The client group ID used to access the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cl-0003jyv******fsku5m</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The connection information of the data source, which describes how to access the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;dataServerAddresses&quot;: [
            ///         {
            ///             &quot;host&quot;: &quot;123.123.123.123&quot;,
            ///             &quot;port&quot;: &quot;8080&quot;
            ///         }
            ///     ],
            ///     &quot;sharePath&quot;: &quot;/share&quot;,
            ///     &quot;mountOptions&quot;: &quot;vers=3&quot;,
            ///     &quot;fileSystemType&quot;: &quot;nfs&quot;
            /// }</para>
            /// </summary>
            [NameInMap("ConnectionInfo")]
            [Validation(Required=false)]
            public string ConnectionInfo { get; set; }

            /// <summary>
            /// <para>The time when the data source was created. UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1770257653</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-000******2nqeo</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMMON_NAS</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMMON_NAS</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>The paths excluded from analysis. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///       &quot;/home/alice/log&quot;
            /// ]</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>The paths included in the analysis. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///       &quot;/home/alice&quot;,
            ///       &quot;/home/bob&quot;
            /// ]</para>
            /// </summary>
            [NameInMap("Include")]
            [Validation(Required=false)]
            public string Include { get; set; }

            /// <summary>
            /// <para>Whether the index is available. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndexAvailable")]
            [Validation(Required=false)]
            public bool? IndexAvailable { get; set; }

            /// <summary>
            /// <para>The index level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>OFF: No index is created.</para>
            /// </description></item>
            /// <item><description><para>META: A metadata index is created.</para>
            /// </description></item>
            /// <item><description><para>ALL: A full-text index is created. This value is deprecated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>META</para>
            /// </summary>
            [NameInMap("IndexLevel")]
            [Validation(Required=false)]
            public string IndexLevel { get; set; }

            /// <summary>
            /// <para>The time when the index was last updated. UNIX timestamp in seconds. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1745454604</para>
            /// </summary>
            [NameInMap("IndexUpdateTime")]
            [Validation(Required=false)]
            public bool? IndexUpdateTime { get; set; }

            /// <summary>
            /// <para>Whether an index is being built. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Indexing")]
            [Validation(Required=false)]
            public bool? Indexing { get; set; }

            /// <summary>
            /// <para>The analysis options. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <para>The analysis paths. Archiving feature only.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The analysis plan ID. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-123***7890</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The analysis schedule. Archiving feature only. Format: <c>I|{startTime}|{interval}</c>. <c>{startTime}</c> is the start time as a UNIX timestamp in seconds. <c>{interval}</c> is the execution interval in ISO 8601 format. Example: PT1H for one hour, P1D for one day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I|1729493847|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// <para>The rate limit configuration. Archiving feature only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6:21:10240</para>
            /// </summary>
            [NameInMap("SpeedLimit")]
            [Validation(Required=false)]
            public string SpeedLimit { get; set; }

            /// <summary>
            /// <para>The time when the data source was last updated. UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1745454604</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The response message. The value is &quot;successful&quot; if the request was successful, or an error message if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36A5CD24-<b><b>-</b></b>-****-5F30C3F1753F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned data sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
