// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStandardSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the standard set.</para>
        /// </summary>
        [NameInMap("StandardSetInfo")]
        [Validation(Required=false)]
        public GetStandardSetResponseBodyStandardSetInfo StandardSetInfo { get; set; }
        public class GetStandardSetResponseBodyStandardSetInfo : TeaModel {
            /// <summary>
            /// <para>The approval configuration for going online.</para>
            /// </summary>
            [NameInMap("ApprovalConfig")]
            [Validation(Required=false)]
            public GetStandardSetResponseBodyStandardSetInfoApprovalConfig ApprovalConfig { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoApprovalConfig : TeaModel {
                /// <summary>
                /// <para>The approval process type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BY_DEFAULT: default approval type.</description></item>
                /// <item><description>BY_TEMPLATE: approval based on an approval template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BY_DEFAULT</para>
                /// </summary>
                [NameInMap("ApprovalType")]
                [Validation(Required=false)]
                public string ApprovalType { get; set; }

                /// <summary>
                /// <para>Indicates whether approval is enabled.</para>
                /// </summary>
                [NameInMap("EnableApproval")]
                [Validation(Required=false)]
                public bool? EnableApproval { get; set; }

                /// <summary>
                /// <para>Indicates whether batch approval submission is enabled.</para>
                /// </summary>
                [NameInMap("IsSubmitInBatch")]
                [Validation(Required=false)]
                public bool? IsSubmitInBatch { get; set; }

                /// <summary>
                /// <para>The approval template ID. This parameter takes effect only when the approval process type is set to BY_TEMPLATE.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>CITY</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the standard set was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetStandardSetResponseBodyStandardSetInfoCreator Creator { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoCreator : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The default standard template ID.</para>
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
            /// <para>The directory to which the standard set belongs.</para>
            /// </summary>
            [NameInMap("DirectoryReference")]
            [Validation(Required=false)]
            public GetStandardSetResponseBodyStandardSetInfoDirectoryReference DirectoryReference { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoDirectoryReference : TeaModel {
                /// <summary>
                /// <para>The parent directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dir1</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

            }

            /// <summary>
            /// <para>The standard set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The user who last modified the standard set.</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public GetStandardSetResponseBodyStandardSetInfoLastModifier LastModifier { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoLastModifier : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The list of maintainers.</para>
            /// </summary>
            [NameInMap("MaintainerList")]
            [Validation(Required=false)]
            public List<GetStandardSetResponseBodyStandardSetInfoMaintainerList> MaintainerList { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoMaintainerList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The list of member groups.</para>
            /// </summary>
            [NameInMap("MemberGroupList")]
            [Validation(Required=false)]
            public List<GetStandardSetResponseBodyStandardSetInfoMemberGroupList> MemberGroupList { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoMemberGroupList : TeaModel {
                /// <summary>
                /// <para>The user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testGroup</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The list of members.</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<GetStandardSetResponseBodyStandardSetInfoMemberList> MemberList { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoMemberList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The time when the standard set was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the standard set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The approval configuration for going offline.</para>
            /// </summary>
            [NameInMap("OfflineApprovalConfig")]
            [Validation(Required=false)]
            public GetStandardSetResponseBodyStandardSetInfoOfflineApprovalConfig OfflineApprovalConfig { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoOfflineApprovalConfig : TeaModel {
                /// <summary>
                /// <para>The approval process type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BY_DEFAULT: default approval type.</description></item>
                /// <item><description>BY_TEMPLATE: approval based on an approval template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BY_DEFAULT</para>
                /// </summary>
                [NameInMap("ApprovalType")]
                [Validation(Required=false)]
                public string ApprovalType { get; set; }

                /// <summary>
                /// <para>Indicates whether approval is enabled.</para>
                /// </summary>
                [NameInMap("EnableApproval")]
                [Validation(Required=false)]
                public bool? EnableApproval { get; set; }

                /// <summary>
                /// <para>Indicates whether batch approval submission is enabled.</para>
                /// </summary>
                [NameInMap("IsSubmitInBatch")]
                [Validation(Required=false)]
                public bool? IsSubmitInBatch { get; set; }

                /// <summary>
                /// <para>The approval template ID. This parameter takes effect only when the approval process type is set to BY_TEMPLATE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

            /// <summary>
            /// <para>The visibility configuration.</para>
            /// </summary>
            [NameInMap("VisibilityConfig")]
            [Validation(Required=false)]
            public GetStandardSetResponseBodyStandardSetInfoVisibilityConfig VisibilityConfig { get; set; }
            public class GetStandardSetResponseBodyStandardSetInfoVisibilityConfig : TeaModel {
                /// <summary>
                /// <para>The list of specified users who can view the standard set. This parameter takes effect only when the visibility type is set to SPECIFIED.</para>
                /// </summary>
                [NameInMap("SpecifiedUserList")]
                [Validation(Required=false)]
                public List<GetStandardSetResponseBodyStandardSetInfoVisibilityConfigSpecifiedUserList> SpecifiedUserList { get; set; }
                public class GetStandardSetResponseBodyStandardSetInfoVisibilityConfigSpecifiedUserList : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000913</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>susan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The visibility type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PUBLIC: public.</description></item>
                /// <item><description>PRIVATE: private. Only standard set members and administrators can view the standard set.</description></item>
                /// <item><description>SPECIFIED: visible to specified users only.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PUBLIC</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
