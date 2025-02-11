// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeTablePartitionDiagnoseResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the request denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;1**<em><b><b><b><b><b><b><b>7&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAAOPdwKY2QLOvgMEc7SkkoJfj1kvZwsaRqNYMh10Tv0wTe0fCzaCdrvgazfNb0EnJKETgXyhR+3BIQjx9WAqZryejBsp1Bl4qI5En/D9dEhcXAtKCxCmE2kZCiEzpy8BoEUt+bs0DmlaGWO5xkEpttypLIB4rUhDvZd+zwPg4EXk4KSSWSWsurxtqDkKEMshKlQFBTKvJcKwyhk62IeYly4hQ+5IpXjkh1GQXuDRCQ==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;2</b></b></b></b></b></b></b></em>9&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;adb:DescribeExcessivePrimaryKeys&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp171g24yvbxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeTablePartitionDiagnoseResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeTablePartitionDiagnoseResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The detection result.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The severity level of the detection result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL</description></item>
            /// <item><description>WARNING</description></item>
            /// <item><description>CRITICAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WARNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The queried partition diagnostic information.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTablePartitionDiagnoseResponseBodyItems> Items { get; set; }
        public class DescribeTablePartitionDiagnoseResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The improper partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[20210110, 20210113,20210123]</para>
            /// </summary>
            [NameInMap("PartitionDetail")]
            [Validation(Required=false)]
            public string PartitionDetail { get; set; }

            /// <summary>
            /// <para>The number of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PartitionNumber")]
            [Validation(Required=false)]
            public int? PartitionNumber { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The storage percentage of the table. Unit: %.</para>
            /// <remarks>
            /// <para> Formula: Table storage percentage = Total data size of a table/Total data size of the cluster × 100%.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>66.23</para>
            /// </summary>
            [NameInMap("SpaceRatio")]
            [Validation(Required=false)]
            public double? SpaceRatio { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total data size of the table. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42949672960</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The recommended maximum number of rows in each partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>640000000</para>
        /// </summary>
        [NameInMap("SuggestMaxRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMaxRecordsPerPartition { get; set; }

        /// <summary>
        /// <para>The recommended minimum number of rows in each partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64000000</para>
        /// </summary>
        [NameInMap("SuggestMinRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMinRecordsPerPartition { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>185</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
