// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeExcessivePrimaryKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried information about the request denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;1906102576997697&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAAOPdwKY2QLOvgMEc7SkkoJfj1kvZwsaRqNYMh10Tv0wTe0fCzaCdrvgazfNb0EnJKETgXyhR+3BIQjx9WAqZryejBsp1Bl4qI5En/D9dEhcXAtKCxCmE2kZCiEzpy8BoEUt+bs0DmlaGWO5xkEpttypLIB4rUhDvZd+zwPg4EXk4KSSWSWsurxtqDkKEMshKlQFBTKvJcNqPqHV6lwR4INiAGjIvK1ngXxN1O+6ORRB6A8YvztEOGywOk81ZmuNk0YrNy+qk7+UVDTHeXKsy8h9e/ePY/LMidj0RCmDpo/YpCumd0UGe0qEPe2U+UJAm/+UHlnEFLVg6BP3yIB5D++MCy7mgWm8Kwyhk62IeYly4hQ+5IpXjkh1GQXuDgLVVPVpxEek9n30vnCUL4KsaMgfa7dgojb+3TM8xGsD2zVK5STJNrsXclscIJEqyNXd7CBYiRJVZi1HPO6drN9WW0chLpCSTgjO8n0bNanZaxXKumW9PSwV58UoSFASeMWfZK3TLngX+oq8nGmnTwcJosVjfF4RGzAnS1IXt0Q9N2WHDnpwyLBU/nOz7Hsy8IZ+h+OVjsBTXSM9688/vOF707a5mNzpETvQeGRcua3A5livcKAM2cML0yeUs/Zyj/+BGqtVa+wektspDHC/CECh6R5lxQjRmUdPawY8VDs2onmdLuEH8DdmYt+Yv/jBFBUMWOyAluzkPYcX5nuQKouCIUJUFTSbsJsuH5CTIh7Ls5rbmkj+T1qTVz8gnDR8LxwaqoMSna+elXgVyOOxXtMkenVntsmoC3p/4G7yTPL1hu8JyWGIIvZHZGGLXGEH7FeSuMV8buKxPGFWG3arG8e9LGvDdz5dgTien4y6G5AQ0o1iQdXDos5VWdH3u7k5PrsvdEOpvMi6uSd8a42na80FsYlgGlwM5upydcWUC5Un2HCkJpT1xgk2L6shdVTrK6bidRrqE784FhW9bBQePzGaxSupPENZya0VUctRt+7uq3QwIn4y5jzjgX0E0jgmqPrgiVDjBesMQZYfGPCGysWYWYzfoh+G6V7N2VVGtNnGUwNWzM0WJBPONAgxPv+AmixFRCQ==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;202515810214480629&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;adb:DescribeExcessivePrimaryKeys&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeExcessivePrimaryKeysResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeExcessivePrimaryKeysResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The severity level of the detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL
            /// WARNNING
            /// CRITICAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
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
        /// <para>863D51B7-5321-41D8-A0B6-A088B0******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried tables that have excessive primary key fields.</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DescribeExcessivePrimaryKeysResponseBodyTables> Tables { get; set; }
        public class DescribeExcessivePrimaryKeysResponseBodyTables : TeaModel {
            /// <summary>
            /// <para>The total number of columns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("ColumnCount")]
            [Validation(Required=false)]
            public int? ColumnCount { get; set; }

            /// <summary>
            /// <para>The queried primary key fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PrimaryKeyColumns")]
            [Validation(Required=false)]
            public string PrimaryKeyColumns { get; set; }

            /// <summary>
            /// <para>The number of primary key fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PrimaryKeyCount")]
            [Validation(Required=false)]
            public int? PrimaryKeyCount { get; set; }

            /// <summary>
            /// <para>The data size of primary key indexes. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("PrimaryKeyIndexSize")]
            [Validation(Required=false)]
            public long? PrimaryKeyIndexSize { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The percentage of the table size. Unit: %.</para>
            /// <remarks>
            /// <para> Formula: Table storage percentage = Total data size of a table/Total data size of the cluster × 100%.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("SpaceRatio")]
            [Validation(Required=false)]
            public double? SpaceRatio { get; set; }

            /// <summary>
            /// <para>The name of the table</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The cold data size. Unit: bytes.</para>
            /// <remarks>
            /// <para> Formula: Cold data size = Data size of table records + Data size of regular indexes + Data size of primary key indexes + Data size of other data.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
