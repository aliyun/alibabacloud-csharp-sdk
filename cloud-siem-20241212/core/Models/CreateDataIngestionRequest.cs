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
        /// <item><description><para>realtime</para>
        /// </description></item>
        /// <item><description><para>scan</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>realtime</para>
        /// </summary>
        [NameInMap("DataIngestionMode")]
        [Validation(Required=false)]
        public string DataIngestionMode { get; set; }

        /// <summary>
        /// <para>The error code for the data ingestion status.</para>
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
        /// <item><description><para>preset</para>
        /// </description></item>
        /// <item><description><para>custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DataIngestionType")]
        [Validation(Required=false)]
        public string DataIngestionType { get; set; }

        /// <summary>
        /// <para>Specifies whether the data source can be edited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSourceEditable")]
        [Validation(Required=false)]
        public bool? DataSourceEditable { get; set; }

        /// <summary>
        /// <para>The ID of the data source.</para>
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
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
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
        /// <para>Specifies whether the normalization rule can be edited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NormalizationRuleEditable")]
        [Validation(Required=false)]
        public bool? NormalizationRuleEditable { get; set; }

        /// <summary>
        /// <para>The ID of the normalization rule.</para>
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
        /// <para>The region where the Data Management hub for threat analysis is located. Select a region for the management hub based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in a region outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of a member. An administrator can use this parameter to assume the permissions of the specified member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The ID of the data source for the scan mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-014frtpy28m5ct2eoyo1</para>
        /// </summary>
        [NameInMap("ScanDataSourceId")]
        [Validation(Required=false)]
        public string ScanDataSourceId { get; set; }

        /// <summary>
        /// <para>The ID of the stream job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>802c0129b6cfd50861d4b25deea29afb</para>
        /// </summary>
        [NameInMap("StreamJobId")]
        [Validation(Required=false)]
        public string StreamJobId { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
