// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetTokenPlanAccountDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTokenPlanAccountDetailResponseBodyData Data { get; set; }
        public class GetTokenPlanAccountDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acc_123456789</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN </description></item>
            /// <item><description>SSO </description></item>
            /// <item><description>SA</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID. This parameter applies only to accounts of the ALIYUN type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1122334455</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The time when the account was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Thu May 28 14:33:52 CST 2026</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The email address. This parameter applies only to accounts of the SSO type.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@email.com">test@email.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The global status of the account. A value of 0 indicates Normal. A value of 1 indicates Frozen.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <para>The display name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of organization memberships in a tree structure (organization → workspace).</para>
            /// </summary>
            [NameInMap("OrgMemberships")]
            [Validation(Required=false)]
            public List<GetTokenPlanAccountDetailResponseBodyDataOrgMemberships> OrgMemberships { get; set; }
            public class GetTokenPlanAccountDetailResponseBodyDataOrgMemberships : TeaModel {
                /// <summary>
                /// <para>The organization member status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ACTIVE </description></item>
                /// <item><description>INITIAL </description></item>
                /// <item><description>FROZEN</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("MemberStatus")]
                [Validation(Required=false)]
                public string MemberStatus { get; set; }

                /// <summary>
                /// <para>The organization ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org_123456789</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The organization role code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ORG_OWNER</description></item>
                /// <item><description>ORG_ADMIN</description></item>
                /// <item><description>ORG_MEMBER</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ORG_MEMBER</para>
                /// </summary>
                [NameInMap("RoleCode")]
                [Validation(Required=false)]
                public string RoleCode { get; set; }

                /// <summary>
                /// <para>The organization role ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_ROLE_ORG_OWNER</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <para>The list of workspaces that the account has joined under the organization.</para>
                /// </summary>
                [NameInMap("Workspaces")]
                [Validation(Required=false)]
                public List<GetTokenPlanAccountDetailResponseBodyDataOrgMembershipsWorkspaces> Workspaces { get; set; }
                public class GetTokenPlanAccountDetailResponseBodyDataOrgMembershipsWorkspaces : TeaModel {
                    /// <summary>
                    /// <para>The member status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ACTIVE </description></item>
                    /// <item><description>FROZEN</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("MemberStatus")]
                    [Validation(Required=false)]
                    public string MemberStatus { get; set; }

                    /// <summary>
                    /// <para>The workspace role code. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>WS_ADMIN</description></item>
                    /// <item><description>WS_MEMBER</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WS_ADMIN</para>
                    /// </summary>
                    [NameInMap("RoleCode")]
                    [Validation(Required=false)]
                    public string RoleCode { get; set; }

                    /// <summary>
                    /// <para>The workspace role ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM_ROLE_WS_ADMIN</para>
                    /// </summary>
                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public string RoleId { get; set; }

                    /// <summary>
                    /// <para>The workspace ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ws_123456789</para>
                    /// </summary>
                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }

            }

        }

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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0DC05D9-C506-519B-AFF3-2B00165176E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
