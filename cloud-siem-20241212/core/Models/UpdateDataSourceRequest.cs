// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSourceRequest : TeaModel {
        [NameInMap("DataSourceFrom")]
        [Validation(Required=false)]
        public string DataSourceFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ds-014frtpy28m5ct2eoyo1。</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ActiontrailLog。</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DataSourceRecognizeEnabled")]
        [Validation(Required=false)]
        public bool? DataSourceRecognizeEnabled { get; set; }

        [NameInMap("DataSourceStores")]
        [Validation(Required=false)]
        public List<UpdateDataSourceRequestDataSourceStores> DataSourceStores { get; set; }
        public class UpdateDataSourceRequestDataSourceStores : TeaModel {
            [NameInMap("DataSourceStoreFrom")]
            [Validation(Required=false)]
            public string DataSourceStoreFrom { get; set; }

            [NameInMap("DataSourceStoreId")]
            [Validation(Required=false)]
            public string DataSourceStoreId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou。</para>
            /// </summary>
            [NameInMap("LogProjectName")]
            [Validation(Required=false)]
            public string LogProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou。</para>
            /// </summary>
            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-rds-sqlaudit。</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou。</para>
        /// </summary>
        [NameInMap("LogProjectName")]
        [Validation(Required=false)]
        public string LogProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-rds-sqlaudit。</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("LogUserId")]
        [Validation(Required=false)]
        public long? LogUserId { get; set; }

        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
