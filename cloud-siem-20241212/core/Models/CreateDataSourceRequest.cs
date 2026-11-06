// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The source of the data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>center</description></item>
        /// <item><description>custom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>center</para>
        /// </summary>
        [NameInMap("DataSourceFrom")]
        [Validation(Required=false)]
        public string DataSourceFrom { get; set; }

        /// <summary>
        /// <para>The list of data source IDs.</para>
        /// </summary>
        [NameInMap("DataSourceIds")]
        [Validation(Required=false)]
        public List<string> DataSourceIds { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD_LOG</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

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
        /// <para>The data source recognizer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_waf_flow_log_1766185894104675</para>
        /// </summary>
        [NameInMap("DataSourceRecognizer")]
        [Validation(Required=false)]
        public string DataSourceRecognizer { get; set; }

        /// <summary>
        /// <para>The data ingestion IDs associated with the data source.</para>
        /// </summary>
        [NameInMap("DataSourceReferences")]
        [Validation(Required=false)]
        public List<string> DataSourceReferences { get; set; }

        /// <summary>
        /// <para>The list of Simple Log Service projects.</para>
        /// </summary>
        [NameInMap("DataSourceStores")]
        [Validation(Required=false)]
        public List<CreateDataSourceRequestDataSourceStores> DataSourceStores { get; set; }
        public class CreateDataSourceRequestDataSourceStores : TeaModel {
            /// <summary>
            /// <para>The source of the data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>center</description></item>
            /// <item><description>custom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("DataSourceStoreFrom")]
            [Validation(Required=false)]
            public string DataSourceStoreFrom { get; set; }

            /// <summary>
            /// <para>The ID of the log storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataSourceStoreId")]
            [Validation(Required=false)]
            public string DataSourceStoreId { get; set; }

            /// <summary>
            /// <para>The log storage status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal</description></item>
            /// <item><description>abnormal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("DataSourceStoreStatus")]
            [Validation(Required=false)]
            public string DataSourceStoreStatus { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou</para>
            /// </summary>
            [NameInMap("LogProjectName")]
            [Validation(Required=false)]
            public string LogProjectName { get; set; }

            /// <summary>
            /// <para>The ID of the log storage region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>actiontrail_management-events</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the data source template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dst_alibaba_cloud_nas_audit_log_1358117679873357</para>
        /// </summary>
        [NameInMap("DataSourceTemplateId")]
        [Validation(Required=false)]
        public string DataSourceTemplateId { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>preset</description></item>
        /// <item><description>custom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>preset</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
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
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogProjectName")]
        [Validation(Required=false)]
        public string LogProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the log storage region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mde_raw</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The ID of the user for data ingestion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public long? LogUserId { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: Descending order.</description></item>
        /// <item><description>asc: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. You must select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: The assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
