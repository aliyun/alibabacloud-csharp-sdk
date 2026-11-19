// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateStandardSetRequest : TeaModel {
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
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateStandardSetRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateStandardSetRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The online approval configuration.</para>
            /// </summary>
            [NameInMap("ApprovalConfig")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandApprovalConfig ApprovalConfig { get; set; }
            public class UpdateStandardSetRequestUpdateCommandApprovalConfig : TeaModel {
                /// <summary>
                /// <para>The approval process type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BY_DEFAULT: Default approval type.</description></item>
                /// <item><description>BY_TEMPLATE: Based on an approval template.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BY_DEFAULT</para>
                /// </summary>
                [NameInMap("ApprovalType")]
                [Validation(Required=false)]
                public string ApprovalType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable approval.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("EnableApproval")]
                [Validation(Required=false)]
                public bool? EnableApproval { get; set; }

                /// <summary>
                /// <para>Specifies whether to submit approvals in batches.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("IsSubmitInBatch")]
                [Validation(Required=false)]
                public bool? IsSubmitInBatch { get; set; }

                /// <summary>
                /// <para>The ID of the approval template. This parameter takes effect only when the approval process type is set to BY_TEMPLATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

            /// <summary>
            /// <para>The code of the standard set.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CITY</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The ID of the default standard template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("DefaultStandardTemplateId")]
            [Validation(Required=false)]
            public long? DefaultStandardTemplateId { get; set; }

            /// <summary>
            /// <para>The description of the standard set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The parent folder.</para>
            /// </summary>
            [NameInMap("DirectoryReference")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandDirectoryReference DirectoryReference { get; set; }
            public class UpdateStandardSetRequestUpdateCommandDirectoryReference : TeaModel {
                /// <summary>
                /// <para>The parent folder.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dir1</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

            }

            /// <summary>
            /// <para>The maintainers.</para>
            /// </summary>
            [NameInMap("MaintainerList")]
            [Validation(Required=false)]
            public List<string> MaintainerList { get; set; }

            /// <summary>
            /// <para>The member group list.</para>
            /// </summary>
            [NameInMap("MemberGroupList")]
            [Validation(Required=false)]
            public List<string> MemberGroupList { get; set; }

            /// <summary>
            /// <para>The member list.</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<string> MemberList { get; set; }

            /// <summary>
            /// <para>The name of the standard set.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The offline approval configuration.</para>
            /// </summary>
            [NameInMap("OfflineApprovalConfig")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandOfflineApprovalConfig OfflineApprovalConfig { get; set; }
            public class UpdateStandardSetRequestUpdateCommandOfflineApprovalConfig : TeaModel {
                /// <summary>
                /// <para>The approval process type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BY_DEFAULT: Default approval type.</description></item>
                /// <item><description>BY_TEMPLATE: Based on an approval template.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BY_DEFAULT</para>
                /// </summary>
                [NameInMap("ApprovalType")]
                [Validation(Required=false)]
                public string ApprovalType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable approval.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("EnableApproval")]
                [Validation(Required=false)]
                public bool? EnableApproval { get; set; }

                /// <summary>
                /// <para>Specifies whether to submit approvals in batches.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("IsSubmitInBatch")]
                [Validation(Required=false)]
                public bool? IsSubmitInBatch { get; set; }

                /// <summary>
                /// <para>The ID of the approval template. This parameter takes effect only when the approval process type is set to BY_TEMPLATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the standard set.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("StandardSetId")]
            [Validation(Required=false)]
            public long? StandardSetId { get; set; }

            /// <summary>
            /// <para>The visibility configuration.</para>
            /// </summary>
            [NameInMap("VisibilityConfig")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandVisibilityConfig VisibilityConfig { get; set; }
            public class UpdateStandardSetRequestUpdateCommandVisibilityConfig : TeaModel {
                /// <summary>
                /// <para>The list of specified users who have visibility. This parameter takes effect only when the visibility type is set to SPECIFIED.</para>
                /// </summary>
                [NameInMap("SpecifiedUserList")]
                [Validation(Required=false)]
                public List<string> SpecifiedUserList { get; set; }

                /// <summary>
                /// <para>The visibility type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PUBLIC: Public.</description></item>
                /// <item><description>PRIVATE: Private. Visible only to standard set members and administrators.</description></item>
                /// <item><description>SPECIFIED: Visible to specified users.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
