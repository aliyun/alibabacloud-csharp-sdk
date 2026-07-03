// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSourceRequest : TeaModel {
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
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DataSourceFrom")]
        [Validation(Required=false)]
        public string DataSourceFrom { get; set; }

        /// <summary>
        /// <para>The ID of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-014frtpy28m5ct2eoyo1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ActiontrailLog</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically discover new Logstores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSourceRecognizeEnabled")]
        [Validation(Required=false)]
        public bool? DataSourceRecognizeEnabled { get; set; }

        /// <summary>
        /// <para>The list of Simple Log Service Logstores.</para>
        /// </summary>
        [NameInMap("DataSourceStores")]
        [Validation(Required=false)]
        public List<UpdateDataSourceRequestDataSourceStores> DataSourceStores { get; set; }
        public class UpdateDataSourceRequestDataSourceStores : TeaModel {
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
            /// <para>custom</para>
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
            /// <para>cn-rds-sqlaudit</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

        }

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
        /// <para>cn-rds-sqlaudit</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The user ID for data access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public long? LogUserId { get; set; }

        /// <summary>
        /// <para>The field to use for sorting the rule list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtModified: Sorts the list by modification time.</para>
        /// </description></item>
        /// <item><description><para>Id: Sorts the list by rule ID. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center for threat analysis. Select a region based on the location of the assets. Valid values:</para>
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
        /// <para>The user ID of the member whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
