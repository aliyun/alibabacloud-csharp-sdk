// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataIngestionTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The status of data ingestion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enabled: Enabled.</para>
        /// </description></item>
        /// <item><description><para>disabled: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("DataIngestionStatus")]
        [Validation(Required=false)]
        public string DataIngestionStatus { get; set; }

        /// <summary>
        /// <para>The ID of the data ingestion template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_ingestion_173326*******</para>
        /// </summary>
        [NameInMap("DataIngestionTemplateId")]
        [Validation(Required=false)]
        public string DataIngestionTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the data source template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_ingestion_173326*******</para>
        /// </summary>
        [NameInMap("DataIngestionTemplateName")]
        [Validation(Required=false)]
        public string DataIngestionTemplateName { get; set; }

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
        /// <para>The ID of the normalization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_rule</para>
        /// </summary>
        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center for threat analysis is located. Select a region for the management center based on the region of your asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: The asset is in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: The asset is outside China.</para>
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
        /// <para>The user ID of the member. This parameter is used by an administrator to switch to the perspective of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
