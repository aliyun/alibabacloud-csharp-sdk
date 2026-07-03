// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataIngestionRequest : TeaModel {
        /// <summary>
        /// <para>The data ingestion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_ingestion_173326*******</para>
        /// </summary>
        [NameInMap("DataIngestionId")]
        [Validation(Required=false)]
        public string DataIngestionId { get; set; }

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
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_log_173326*******</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The language of the response messages. Valid values:</para>
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
        /// <para>The normalization rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_rule</para>
        /// </summary>
        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center for threat analysis. Select the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: The assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: The assets are in a region outside China.</para>
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
        /// <para>The user ID of a member. An administrator can perform operations on behalf of this member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
