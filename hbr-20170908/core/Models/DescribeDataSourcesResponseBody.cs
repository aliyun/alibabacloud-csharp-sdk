// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<DescribeDataSourcesResponseBodyDataSources> DataSources { get; set; }
        public class DescribeDataSourcesResponseBodyDataSources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[
            ///       &quot;/home/alice/log&quot;
            /// ]</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;dataServerAddresses&quot;: [
            ///             {
            ///                   &quot;host&quot;: &quot;123.123.123.123&quot;,
            ///                   &quot;port&quot;: &quot;8080&quot;
            ///             }
            ///       ],
            ///       &quot;sharePath&quot;: &quot;/share&quot;,
            ///       &quot;mountOptions&quot;: &quot;&quot;,
            ///       &quot;fileSystemType&quot;: &quot;nfs&quot;
            /// }</para>
            /// </summary>
            [NameInMap("ConnectionInfo")]
            [Validation(Required=false)]
            public string ConnectionInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1770257653</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds-000******2nqeo</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMMON_NAS</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMMON_NAS</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[
            ///       &quot;/home/alice/log&quot;
            /// ]</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndexAvailable")]
            [Validation(Required=false)]
            public bool? IndexAvailable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>META</para>
            /// </summary>
            [NameInMap("IndexLevel")]
            [Validation(Required=false)]
            public string IndexLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1745454604</para>
            /// </summary>
            [NameInMap("IndexUpdateTime")]
            [Validation(Required=false)]
            public bool? IndexUpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Indexing")]
            [Validation(Required=false)]
            public bool? Indexing { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>plan-123***7890</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>I|1729493847|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6:21:10240</para>
            /// </summary>
            [NameInMap("SpeedLimit")]
            [Validation(Required=false)]
            public string SpeedLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1745454604</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>36A5CD24-<b><b>-</b></b>-****-5F30C3F1753F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
