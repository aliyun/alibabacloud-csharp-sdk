// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataConnectorsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of collector IDs.</para>
        /// </summary>
        [NameInMap("DataConnectorIds")]
        [Validation(Required=false)]
        public string DataConnectorIdsShrink { get; set; }

        /// <summary>
        /// <para>The collector name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAS-CTDR-2026070210****</para>
        /// </summary>
        [NameInMap("DataConnectorName")]
        [Validation(Required=false)]
        public string DataConnectorName { get; set; }

        /// <summary>
        /// <para>The collector status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>&quot;enabled&quot;: enabled.</description></item>
        /// <item><description>&quot;disabled&quot; (default): disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("DataConnectorStatus")]
        [Validation(Required=false)]
        public string DataConnectorStatus { get; set; }

        /// <summary>
        /// <para>The collector type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss</description></item>
        /// <item><description>s3</description></item>
        /// <item><description>kafka</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s3</para>
        /// </summary>
        [NameInMap("DataConnectorType")]
        [Validation(Required=false)]
        public string DataConnectorType { get; set; }

        /// <summary>
        /// <para>The destination data source ID. This parameter is required only for synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-5sfe68t122pxnti1cjpl</para>
        /// </summary>
        [NameInMap("DestDataSourceId")]
        [Validation(Required=false)]
        public string DestDataSourceId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return when you use the NextToken-based pagination method. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. You do not need to set this parameter for the first request or if no more results exist. If more results exist, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort field. Currently, only sorting by updateTime is supported. If OrderField is left empty, the default order returned by the database is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>&quot;asc&quot;: ascending order.</description></item>
        /// <item><description>&quot;desc&quot; (default): descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the threat analysis data management center resides. Specify the management center region based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: The assets reside outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID that the administrator switches to when viewing as another member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service (SLS) data import job for the collector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-oss-dc-1a2b3c4d5e6f7a8****</para>
        /// </summary>
        [NameInMap("SlsIngestionJobName")]
        [Validation(Required=false)]
        public string SlsIngestionJobName { get; set; }

        /// <summary>
        /// <para>The source data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s3</para>
        /// </summary>
        [NameInMap("SrcDataType")]
        [Validation(Required=false)]
        public string SrcDataType { get; set; }

    }

}
