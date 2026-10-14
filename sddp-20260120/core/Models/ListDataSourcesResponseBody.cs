// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of records returned by the query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListDataSourcesResponseBodyItems> Items { get; set; }
        public class ListDataSourcesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The connection status of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>UnConnected: Not connected.</description></item>
            /// <item><description>Processing: Connecting.</description></item>
            /// <item><description>Success: Connected.</description></item>
            /// <item><description>Failed: Connection failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ConnectStatus")]
            [Validation(Required=false)]
            public string ConnectStatus { get; set; }

            /// <summary>
            /// <para>The identifier of the data asset in Data Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-example-001</para>
            /// </summary>
            [NameInMap("DataAssetId")]
            [Validation(Required=false)]
            public string DataAssetId { get; set; }

            /// <summary>
            /// <para>The identifier of the data source in Data Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-example-001</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The statistical value of the data source capacity. This field is not used in the column encryption process for relational databases.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("DataSourceSize")]
            [Validation(Required=false)]
            public long? DataSourceSize { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The description of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business data source</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The business error code of the record or operation. This field can be empty if no error occurs. Evaluate this field together with ErrorMessage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_masking_not_running</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The business error message of the record or operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instance is not in the running state</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The identifier of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The status of the data source detection switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enable: Submitted for enabling.</description></item>
            /// <item><description>Enabling: Enabling.</description></item>
            /// <item><description>Enabled: Enabled.</description></item>
            /// <item><description>EnableFailed: Enabling failed.</description></item>
            /// <item><description>Disable: Submitted for disabling.</description></item>
            /// <item><description>Disabling: Disabling.</description></item>
            /// <item><description>Disabled: Disabled.</description></item>
            /// <item><description>DisableFailed: Disabling failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("IdentifyStatus")]
            [Validation(Required=false)]
            public string IdentifyStatus { get; set; }

            /// <summary>
            /// <para>The database instance identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1abcdefgh****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The identity of the member accounts to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012****</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>The port for the database connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The identifier of the cloud service type. 5: ApsaraDB RDS; 8: PolarDB; 27: PolarDB-X 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region where the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Zhangjiakou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmexample****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The identifier of the database tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tenant-example</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The name of the database account used to connect to the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsc_reader</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records that can be returned for the current cursor-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A compatible pagination cursor field. The ListDataSources operation uses page number-based pagination and does not rely on this field to determine whether more pages exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of records returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request identity, which is active when you invoke this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the current statistics or query scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
