// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataIngestionRequest : TeaModel {
        /// <summary>
        /// <para>The number of associated security capabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CapacityCount")]
        [Validation(Required=false)]
        public int? CapacityCount { get; set; }

        /// <summary>
        /// <para>The data ingestion mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>realtime</description></item>
        /// <item><description>scan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>realtime</para>
        /// </summary>
        [NameInMap("DataIngestionMode")]
        [Validation(Required=false)]
        public string DataIngestionMode { get; set; }

        /// <summary>
        /// <para>The status code for data ingestion exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserUnauthorized</para>
        /// </summary>
        [NameInMap("DataIngestionStateCode")]
        [Validation(Required=false)]
        public string DataIngestionStateCode { get; set; }

        /// <summary>
        /// <para>The data ingestion type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>preset</description></item>
        /// <item><description>custom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DataIngestionType")]
        [Validation(Required=false)]
        public string DataIngestionType { get; set; }

        /// <summary>
        /// <para>Specifies whether the data source is editable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSourceEditable")]
        [Validation(Required=false)]
        public bool? DataSourceEditable { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <remarks>
        /// <para>This parameter is required in practice. If you do not specify this parameter, the API returns a 400 error: &quot;The specified DataSourceId is invalid.&quot;
        /// Before calling this operation, call the CreateDataSource operation to create a data source and obtain the data source ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ds-3g6lyf4eonngyohaq7tr</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.<remarks>
        /// <para>This parameter is required in practice. If you do not specify this parameter, the API returns a 400 error: &quot;The specified Lang can not be empty.&quot;</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether the normalization rule is editable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NormalizationRuleEditable")]
        [Validation(Required=false)]
        public bool? NormalizationRuleEditable { get; set; }

        /// <summary>
        /// <para>The normalization rule ID.
        /// Before calling this operation, call the CreateNormalizationRule operation to create a normalization rule and obtain the normalization rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nr-hdmady54piigkjfv17yp</para>
        /// </summary>
        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region of the management center for threat analysis. Specify the management center based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside China.</description></item>
        /// <item><description>cn-shanghai: The actual effective value. RegionId refers to the management center location, which is a different dimension from the API endpoint region (cn-shanghai).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The data source ID for scan mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-014frtpy28m5ct2eoyo1</para>
        /// </summary>
        [NameInMap("ScanDataSourceId")]
        [Validation(Required=false)]
        public string ScanDataSourceId { get; set; }

        /// <summary>
        /// <para>The job ID of the stream task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>802c0129b6cfd50861d4b25deea29afb</para>
        /// </summary>
        [NameInMap("StreamJobId")]
        [Validation(Required=false)]
        public string StreamJobId { get; set; }

        /// <summary>
        /// <para>The update time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
