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
        /// <item><description><para>center</para>
        /// </description></item>
        /// <item><description><para>custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>center</para>
        /// </summary>
        [NameInMap("DataSourceFrom")]
        [Validation(Required=false)]
        public string DataSourceFrom { get; set; }

        /// <summary>
        /// <para>A list of data source IDs.</para>
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
        /// <para>The IDs of associated data access instances.</para>
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
            /// <item><description><para>center</para>
            /// </description></item>
            /// <item><description><para>custom</para>
            /// </description></item>
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
            /// <para>The status of the log storage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>normal</para>
            /// </description></item>
            /// <item><description><para>abnormal</para>
            /// </description></item>
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
        /// <item><description><para>preset</para>
        /// </description></item>
        /// <item><description><para>custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>preset</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

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
        /// <para>The user ID for data ingestion.</para>
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
        /// <item><description><para>desc: descending.</para>
        /// </description></item>
        /// <item><description><para>asc: ascending.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The region of the Management Hub. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Assets are outside China.</para>
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
        /// <para>The user ID of the member whose perspective the administrator assumes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
