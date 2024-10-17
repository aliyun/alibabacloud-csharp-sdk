// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCronClearOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key of the attachment for the ticket. The attachment provides more instructions for this operation.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to query the key of the attachment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_attachement.txt</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>The purpose or objective of the data change. This reduces unnecessary communication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The parameters of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataCronClearOrderRequestParam Param { get; set; }
        public class CreateDataCronClearOrderRequestParam : TeaModel {
            /// <summary>
            /// <para>The reason for the data change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The tables for which you want to clear historical data.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CronClearItemList")]
            [Validation(Required=false)]
            public List<CreateDataCronClearOrderRequestParamCronClearItemList> CronClearItemList { get; set; }
            public class CreateDataCronClearOrderRequestParamCronClearItemList : TeaModel {
                /// <summary>
                /// <para>The name of the field.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gmt_create</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The filter conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>where 1 = 1</para>
                /// </summary>
                [NameInMap("FilterSQL")]
                [Validation(Required=false)]
                public string FilterSQL { get; set; }

                /// <summary>
                /// <para>The retention period of the historical data. Unit: days. For example, if you set the parameter to 7, DMS deletes the data that is retained for more than seven days.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("RemainDays")]
                [Validation(Required=false)]
                public long? RemainDays { get; set; }

                /// <summary>
                /// <para>The name of the table. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the name of the table.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t1</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The type of time granularity. If the ColumnName parameter specifies a field of a time type, this parameter is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>MILLISECONDS</b>: milliseconds</description></item>
                /// <item><description><b>SECONDS</b>: seconds</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MILLISECONDS</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

            /// <summary>
            /// <para>The crontab expression that you can use to run the task at a specified time. For more information, see <a href="https://help.aliyun.com/document_detail/206581.html">Crontab expression</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 2 * * ?</para>
            /// </summary>
            [NameInMap("CronFormat")]
            [Validation(Required=false)]
            public string CronFormat { get; set; }

            /// <summary>
            /// <para>The databases for which you want to clear historical data.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataCronClearOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataCronClearOrderRequestParamDbItemList : TeaModel {
                /// <summary>
                /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabases</a> operation to query the ID of the database.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is not a logical database.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            /// <summary>
            /// <para>The amount of time taken to run the task. Unit: hours.</para>
            /// <remarks>
            /// <para> If the <b>specifyDuration</b> parameter is set to <b>true</b>, this parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DurationHour")]
            [Validation(Required=false)]
            public long? DurationHour { get; set; }

            /// <summary>
            /// <para>Specifies whether to specify an end time for the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: specifies an end time for the task. The task is automatically suspended after this end time.</description></item>
            /// <item><description><b>false</b>: does not specify an end time for the task. The task is stopped after the historical data is cleared.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("specifyDuration")]
            [Validation(Required=false)]
            public bool? SpecifyDuration { get; set; }

        }

        /// <summary>
        /// <para>The stakeholders of this operation. All stakeholders can view the ticket details and assist in the approval process. Irrelevant users other than Data Management (DMS) administrators and database administrators (DBAs) are not allowed to view the ticket details.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para> The ID of the tenant is displayed when you move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the Manage DMS tenants topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123454324</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
