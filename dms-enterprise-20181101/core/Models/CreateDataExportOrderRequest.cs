// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataExportOrderRequest : TeaModel {
        /// <summary>
        /// The key of the attachment that provides more instructions for the ticket. You can call the [GetUserUploadFileJob](https://help.aliyun.com/document_detail/206069.html) operation to obtain the attachment key.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The purpose or objective of the ticket. This parameter helps reduce unnecessary communication.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the parent ticket.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PluginParam")]
        [Validation(Required=false)]
        public CreateDataExportOrderRequestPluginParam PluginParam { get; set; }
        public class CreateDataExportOrderRequestPluginParam : TeaModel {
            /// <summary>
            /// The estimated number of data rows to be affected.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// The reason for the export ticket.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// The database ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The SQL statements that can be executed.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ExeSQL")]
            [Validation(Required=false)]
            public string ExeSQL { get; set; }

            /// <summary>
            /// Specifies whether to skip verification. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("IgnoreAffectRows")]
            [Validation(Required=false)]
            public bool? IgnoreAffectRows { get; set; }

            /// <summary>
            /// The reason for skipping verification. This parameter is required if you set IgnoreAffectRows to true.
            /// </summary>
            [NameInMap("IgnoreAffectRowsReason")]
            [Validation(Required=false)]
            public string IgnoreAffectRowsReason { get; set; }

            /// <summary>
            /// The instance ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// Specifies whether the database is a logical database. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > If you set this parameter to **true**, the database that you specify must be a logical database.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// The information about the watermarks.
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public CreateDataExportOrderRequestPluginParamWatermark Watermark { get; set; }
            public class CreateDataExportOrderRequestPluginParamWatermark : TeaModel {
                /// <summary>
                /// The field into which the watermark is to be embedded.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The information to be embedded as a watermark into data.
                /// </summary>
                [NameInMap("DataWatermark")]
                [Validation(Required=false)]
                public string DataWatermark { get; set; }

                /// <summary>
                /// The information to be embedded as a watermark into files.
                /// </summary>
                [NameInMap("FileWatermark")]
                [Validation(Required=false)]
                public string FileWatermark { get; set; }

                /// <summary>
                /// One or more primary keys or unique keys.
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<string> Keys { get; set; }

                /// <summary>
                /// The methods in which the watermark is embedded.
                /// </summary>
                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// The stakeholders involved in this operation.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// The tenant ID.
        /// 
        /// > To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html) section of the "Manage DMS tenants" topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
