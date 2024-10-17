// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataExportOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key of the attachment that provides more instructions for the ticket. You can call the <a href="https://help.aliyun.com/document_detail/206069.html">GetUserUploadFileJob</a> operation to obtain the attachment key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_attachment.txt</para>
        /// </summary>
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// <para>The purpose or objective of the ticket. This parameter helps reduce unnecessary communication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>business_test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the parent ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>877****</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>The parameters of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PluginParam")]
        [Validation(Required=false)]
        public CreateDataExportOrderRequestPluginParam PluginParam { get; set; }
        public class CreateDataExportOrderRequestPluginParam : TeaModel {
            /// <summary>
            /// <para>The estimated number of data rows to be affected.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// <para>The reason for the export ticket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The SQL statements that can be executed.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM DMS_test
            ///  LIMIT 20;</para>
            /// </summary>
            [NameInMap("ExeSQL")]
            [Validation(Required=false)]
            public string ExeSQL { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip verification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IgnoreAffectRows")]
            [Validation(Required=false)]
            public bool? IgnoreAffectRows { get; set; }

            /// <summary>
            /// <para>The reason for skipping verification. This parameter is required if you set IgnoreAffectRows to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test only, does not affect the business, and does not require verification.</para>
            /// </summary>
            [NameInMap("IgnoreAffectRowsReason")]
            [Validation(Required=false)]
            public string IgnoreAffectRowsReason { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>Specifies whether the database is a logical database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>If you set this parameter to <b>true</b>, the database that you specify must be a logical database.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>The information about the watermarks.</para>
            /// </summary>
            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public CreateDataExportOrderRequestPluginParamWatermark Watermark { get; set; }
            public class CreateDataExportOrderRequestPluginParamWatermark : TeaModel {
                /// <summary>
                /// <para>The field into which the watermark is to be embedded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_number</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The information to be embedded as a watermark into data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DataWatermark")]
                [Validation(Required=false)]
                public string DataWatermark { get; set; }

                /// <summary>
                /// <para>The information to be embedded as a watermark into files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FileWatermark")]
                [Validation(Required=false)]
                public string FileWatermark { get; set; }

                /// <summary>
                /// <para>One or more primary keys or unique keys.</para>
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<string> Keys { get; set; }

                /// <summary>
                /// <para>The methods in which the watermark is embedded.</para>
                /// </summary>
                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account that actually calls the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21400447956867****</para>
        /// </summary>
        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The stakeholders involved in this operation.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
