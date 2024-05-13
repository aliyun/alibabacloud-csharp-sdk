// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCronClearOrderRequest : TeaModel {
        /// <summary>
        /// The key of the attachment for the ticket. The attachment provides more instructions for this operation.
        /// 
        /// You can call the [GetUserUploadFileJob](https://help.aliyun.com/document_detail/206069.html) operation to query the key of the attachment.
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// The purpose or objective of the data change. This reduces unnecessary communication.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataCronClearOrderRequestParam Param { get; set; }
        public class CreateDataCronClearOrderRequestParam : TeaModel {
            /// <summary>
            /// The reason for the data change.
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// The tables for which you want to clear historical data.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CronClearItemList")]
            [Validation(Required=false)]
            public List<CreateDataCronClearOrderRequestParamCronClearItemList> CronClearItemList { get; set; }
            public class CreateDataCronClearOrderRequestParamCronClearItemList : TeaModel {
                /// <summary>
                /// The name of the field.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The filter conditions.
                /// </summary>
                [NameInMap("FilterSQL")]
                [Validation(Required=false)]
                public string FilterSQL { get; set; }

                /// <summary>
                /// The retention period of the historical data. Unit: days. For example, if you set the parameter to 7, DMS deletes the data that is retained for more than seven days.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("RemainDays")]
                [Validation(Required=false)]
                public long? RemainDays { get; set; }

                /// <summary>
                /// The name of the table. You can call the [ListTables](https://help.aliyun.com/document_detail/141878.html) operation to query the name of the table.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The type of time granularity. If the ColumnName parameter specifies a field of a time type, this parameter is required. Valid values:
                /// 
                /// *   **MILLISECONDS**: milliseconds
                /// *   **SECONDS**: seconds
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

            /// <summary>
            /// The crontab expression that you can use to run the task at a specified time. For more information, see [Crontab expression](https://help.aliyun.com/document_detail/206581.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CronFormat")]
            [Validation(Required=false)]
            public string CronFormat { get; set; }

            /// <summary>
            /// The databases for which you want to clear historical data.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataCronClearOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataCronClearOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// The ID of the database. You can call the [SearchDatabases](https://help.aliyun.com/document_detail/141876.html) operation to query the ID of the database.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is not a logical database.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            /// <summary>
            /// The amount of time taken to run the task. Unit: hours.
            /// 
            /// >  If the **specifyDuration** parameter is set to **true**, this parameter is required.
            /// </summary>
            [NameInMap("DurationHour")]
            [Validation(Required=false)]
            public long? DurationHour { get; set; }

            /// <summary>
            /// Specifies whether to specify an end time for the task. Valid values:
            /// 
            /// *   **true**: specifies an end time for the task. The task is automatically suspended after this end time.
            /// *   **false**: does not specify an end time for the task. The task is stopped after the historical data is cleared.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("specifyDuration")]
            [Validation(Required=false)]
            public bool? SpecifyDuration { get; set; }

        }

        /// <summary>
        /// The stakeholders of this operation. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than Data Management (DMS) administrators and database administrators (DBAs) are not allowed to view the ticket details.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// >  The ID of the tenant is displayed when you move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html) section of the Manage DMS tenants topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
