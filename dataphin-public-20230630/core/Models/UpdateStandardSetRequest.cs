// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateStandardSetRequest : TeaModel {
        /// <summary>
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateStandardSetRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateStandardSetRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>Publishing approval configuration.</para>
            /// </summary>
            [NameInMap("ApprovalConfig")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandApprovalConfig ApprovalConfig { get; set; }
            public class UpdateStandardSetRequestUpdateCommandApprovalConfig : TeaModel {
                /// <summary>
                /// <para>Approval process type. Valid values: BY_DEFAULT (default approval type) and BY_TEMPLATE (template-based approval).</para>
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
                /// <para>Specifies whether to submit approvals in batch.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("IsSubmitInBatch")]
                [Validation(Required=false)]
                public bool? IsSubmitInBatch { get; set; }

                /// <summary>
                /// <para>Approval template ID. This parameter takes effect only when the approval process type is set to BY_TEMPLATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

            /// <summary>
            /// <para>Standard set code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CITY</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Default standard template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("DefaultStandardTemplateId")]
            [Validation(Required=false)]
            public long? DefaultStandardTemplateId { get; set; }

            /// <summary>
            /// <para>Standard set description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Parent directory.</para>
            /// </summary>
            [NameInMap("DirectoryReference")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandDirectoryReference DirectoryReference { get; set; }
            public class UpdateStandardSetRequestUpdateCommandDirectoryReference : TeaModel {
                /// <summary>
                /// <para>Directory.</para>
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
            /// <para>Maintainers.</para>
            /// </summary>
            [NameInMap("MaintainerList")]
            [Validation(Required=false)]
            public List<string> MaintainerList { get; set; }

            /// <summary>
            /// <para>Member group list.</para>
            /// </summary>
            [NameInMap("MemberGroupList")]
            [Validation(Required=false)]
            public List<string> MemberGroupList { get; set; }

            /// <summary>
            /// <para>Member list.</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<string> MemberList { get; set; }

            /// <summary>
            /// <para>Standard set name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Unpublishing approval configuration.</para>
            /// </summary>
            [NameInMap("OfflineApprovalConfig")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandOfflineApprovalConfig OfflineApprovalConfig { get; set; }
            public class UpdateStandardSetRequestUpdateCommandOfflineApprovalConfig : TeaModel {
                /// <summary>
                /// <para>Approval process type. Valid values: BY_DEFAULT (default approval type) and BY_TEMPLATE (template-based approval).</para>
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
                /// <para>Specifies whether to submit approvals in batch.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("IsSubmitInBatch")]
                [Validation(Required=false)]
                public bool? IsSubmitInBatch { get; set; }

                /// <summary>
                /// <para>Approval template ID. This parameter takes effect only when the approval process type is set to BY_TEMPLATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

            /// <summary>
            /// <para>Standard set ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("StandardSetId")]
            [Validation(Required=false)]
            public long? StandardSetId { get; set; }

            /// <summary>
            /// <para>Visibility configuration.</para>
            /// </summary>
            [NameInMap("VisibilityConfig")]
            [Validation(Required=false)]
            public UpdateStandardSetRequestUpdateCommandVisibilityConfig VisibilityConfig { get; set; }
            public class UpdateStandardSetRequestUpdateCommandVisibilityConfig : TeaModel {
                /// <summary>
                /// <para>List of specified visible users. This parameter takes effect only when the visibility type is set to SPECIFIED.</para>
                /// </summary>
                [NameInMap("SpecifiedUserList")]
                [Validation(Required=false)]
                public List<string> SpecifiedUserList { get; set; }

                /// <summary>
                /// <para>Visibility type. Valid values: PUBLIC (public access), PRIVATE (private access, visible only to standard set members and administrators), and SPECIFIED (visible to specified users).</para>
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
