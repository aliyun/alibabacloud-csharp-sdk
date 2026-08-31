// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityArchiveTableRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The upsert command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityArchiveTableRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityArchiveTableRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>The mode for adding the archived table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATE_NEW_TABLE: creates a new table.</description></item>
            /// <item><description>BIND_EXIST_TABLE: binds an existing table.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_NEW_TABLE</para>
            /// </summary>
            [NameInMap("AddMode")]
            [Validation(Required=false)]
            public string AddMode { get; set; }

            /// <summary>
            /// <para>The ID of the archived table. If this parameter is specified, the operation runs in update mode, and you cannot specify AddMode or NewTableNamePrefix. If this parameter is not specified, the operation runs in create mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88012</para>
            /// </summary>
            [NameInMap("ArchiveTableId")]
            [Validation(Required=false)]
            public long? ArchiveTableId { get; set; }

            /// <summary>
            /// <para>The name of the existing table. This parameter is required when AddMode is set to BIND_EXIST_TABLE. For Dataphin tables, use the format &quot;project_name.table_name&quot; (for example, dataphin03.ads_region_order_summary). For datasource tables, use the format &quot;database/schema.table_name&quot; (for example, order_db.order_exception_data). The table must belong to the same project or datasource as the monitored object, and the table schema must contain system fields with the dataphin_quality_ prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataphin03.ads_region_order_summary</para>
            /// </summary>
            [NameInMap("ExistTableName")]
            [Validation(Required=false)]
            public string ExistTableName { get; set; }

            /// <summary>
            /// <para>The lifecycle of the table, in days. The value must be a positive integer. If this parameter is not specified, no lifecycle is set. This parameter is valid only when creating a new table or in edit pattern, and only when the table belongs to MaxCompute, Hadoop series, or Hive. This parameter cannot be specified when AddMode is set to BIND_EXIST_TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Lifecycle")]
            [Validation(Required=false)]
            public int? Lifecycle { get; set; }

            /// <summary>
            /// <para>The maximum number of archived rows. A positive integer specifies the limit on the number of archived rows. The console provides options of 10,000, 100,000, and 500,000. A value of -1 indicates full archiving. Default value: 10000. This parameter is supported only for MaxCompute, Hadoop series, or Hive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("MaxArchiveCount")]
            [Validation(Required=false)]
            public long? MaxArchiveCount { get; set; }

            /// <summary>
            /// <para>The table name prefix for the new archived table. This parameter is required when AddMode is set to CREATE_NEW_TABLE. The system automatically appends the _exception_data suffix. For example, if you specify vip_user_tips112, the actual table name is vip_user_tips112_exception_data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vip_user_tips112</para>
            /// </summary>
            [NameInMap("NewTableNamePrefix")]
            [Validation(Required=false)]
            public string NewTableNamePrefix { get; set; }

            /// <summary>
            /// <para>Specifies whether to set the archived table as the active table. Only the value true is supported. After the table is set as active, the previously active table under the same monitored object is automatically deactivated (only one active table is allowed at a time). If you set this parameter to false, an InvalidParameter error is returned. If this parameter is not specified, the default value true is used. If this parameter is left empty, the active status remains unchanged.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SetActive")]
            [Validation(Required=false)]
            public bool? SetActive { get; set; }

            /// <summary>
            /// <para>The ID of the monitored object to which the archived table belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
