// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListDataSourcesRequest : TeaModel {
        /// <summary>
        /// <para>The connection status of the data source. Valid values: UnConnected: not connected. Processing: connecting. Success: connected. Failed: connection failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ConnectStatus")]
        [Validation(Required=false)]
        public string ConnectStatus { get; set; }

        /// <summary>
        /// <para>The current page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The identifier of the data source in Data Security Center. You can obtain the value from the Items[].DataSourceId parameter in the response of the ListDataSources operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-example-001</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

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
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The status of the data source detection switch. Valid values: Enable: submitted for enabling. Enabling: enabling. Enabled: enabled. EnableFailed: enabling failed. Disable: submitted for disabling. Disabling: disabling. Disabled: disabled. DisableFailed: disabling failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("IdentifyStatus")]
        [Validation(Required=false)]
        public string IdentifyStatus { get; set; }

        /// <summary>
        /// <para>The database instance identity. You can obtain the value from the Items[].InstanceId parameter in the response of the ListDataMaskingInstances operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values: zh: Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>A reserved pagination parameter. The ListDataSources operation uses CurrentPage and PageSize for pagination. Omit this parameter when you call the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A reserved pagination cursor parameter. The ListDataSources operation uses CurrentPage and PageSize for pagination. Omit this parameter when you call the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Keep other filter conditions consistent when you query the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The database connection port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Column encryption supports ApsaraDB RDS, PolarDB, and PolarDB-X 2.0. If this parameter is specified together with ProductId, the values must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The identifier of the cloud service type. 5: ApsaraDB RDS. 8: PolarDB. 27: PolarDB-X 2.0. If this parameter is specified together with ProductCode, the values must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The source IP address of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.1</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
