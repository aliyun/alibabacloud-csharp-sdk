// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSourceTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically discover new users.</para>
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
        [NameInMap("AutoScanNew")]
        [Validation(Required=false)]
        public string AutoScanNew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically discover new data sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSourceRecognizeEnabled")]
        [Validation(Required=false)]
        public bool? DataSourceRecognizeEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the data source template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_ingestion</para>
        /// </summary>
        [NameInMap("DataSourceTemplateId")]
        [Validation(Required=false)]
        public string DataSourceTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the data source template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_ingestion</para>
        /// </summary>
        [NameInMap("DataSourceTemplateName")]
        [Validation(Required=false)]
        public string DataSourceTemplateName { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
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
        /// <para>The matching rule for the names of Simple Log Service projects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cloudsiem-data-173326*******</para>
        /// </summary>
        [NameInMap("LogProjectPattern")]
        [Validation(Required=false)]
        public string LogProjectPattern { get; set; }

        /// <summary>
        /// <para>The list of IDs of log storage regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogRegionIds")]
        [Validation(Required=false)]
        public string LogRegionIds { get; set; }

        /// <summary>
        /// <para>The matching rule for the names of Simple Log Service Logstores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audit-activity</para>
        /// </summary>
        [NameInMap("LogStorePattern")]
        [Validation(Required=false)]
        public string LogStorePattern { get; set; }

        /// <summary>
        /// <para>The list of user IDs for batch data access.</para>
        /// </summary>
        [NameInMap("LogUserIds")]
        [Validation(Required=false)]
        public string LogUserIdsShrink { get; set; }

        /// <summary>
        /// <para>The region where the Management Hub of threat analysis is located. Select a region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Assets are outside the Chinese mainland.</para>
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
        /// <para>The user ID of the member. This parameter lets an administrator switch to the perspective of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
