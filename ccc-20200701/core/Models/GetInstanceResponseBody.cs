// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of administrators.</para>
            /// </summary>
            [NameInMap("AdminList")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataAdminList> AdminList { get; set; }
            public class GetInstanceResponseBodyDataAdminList : TeaModel {
                /// <summary>
                /// <para>The display name of the administrator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Administrator</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The extension number of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8032****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The logon name of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("LoginName")]
                [Validation(Required=false)]
                public string LoginName { get; set; }

                /// <summary>
                /// <para>The personal phone number of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1382114****</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>The role ID, in the format of Role@Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Admin@ccc-test</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <para>The role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Admin</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The work mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON_SITE</para>
                /// </summary>
                [NameInMap("WorkMode")]
                [Validation(Required=false)]
                public string WorkMode { get; set; }

            }

            /// <summary>
            /// <para>The agent type used by the instance.</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>157123456789****</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The chatbot business unit associated with the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;UnitId&quot;:0,&quot;UnitKey&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ChatbotBusinessUnit")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataChatbotBusinessUnit ChatbotBusinessUnit { get; set; }
            public class GetInstanceResponseBodyDataChatbotBusinessUnit : TeaModel {
                /// <summary>
                /// <para>The ID of the chatbot business unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                /// <summary>
                /// <para>The identifier of the chatbot business unit.</para>
                /// </summary>
                [NameInMap("UnitKey")]
                [Validation(Required=false)]
                public string UnitKey { get; set; }

            }

            /// <summary>
            /// <para>The URL of the Cloud Call Center instance. This URL is used to access the homepage of the instance and consists of a specific Cloud Call Center URL and the instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ccc-v2.aliyun.com/#/workbench/ccc-test">https://ccc-v2.aliyun.com/#/workbench/ccc-test</a></para>
            /// </summary>
            [NameInMap("ConsoleUrl")]
            [Validation(Required=false)]
            public string ConsoleUrl { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test instance of Cloud Call Center</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The globally unique domain name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test instance</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of phone numbers.</para>
            /// </summary>
            [NameInMap("NumberList")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataNumberList> NumberList { get; set; }
            public class GetInstanceResponseBodyDataNumberList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the phone number is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>The city to which the phone number belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Leshan</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <para>The ID of the contact flow (IVR) associated with the phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2ec7a58f-3243-4815-bb21-97b480b95f5e</para>
                /// </summary>
                [NameInMap("ContactFlowId")]
                [Validation(Required=false)]
                public string ContactFlowId { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0830011****</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>The province to which the phone number belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sichuan</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                /// <summary>
                /// <para>The list of skill groups associated with the phone number.</para>
                /// </summary>
                [NameInMap("SkillGroups")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyDataNumberListSkillGroups> SkillGroups { get; set; }
                public class GetInstanceResponseBodyDataNumberListSkillGroups : TeaModel {
                    /// <summary>
                    /// <para>The description of the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test skill group of Cloud Call Center</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The display name of the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test skill group</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ccc-test</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The skill group name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The number of phone numbers associated with the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PhoneNumberCount")]
                    [Validation(Required=false)]
                    public int? PhoneNumberCount { get; set; }

                    /// <summary>
                    /// <para>The skill group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup@ccc-test</para>
                    /// </summary>
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    /// <summary>
                    /// <para>The number of agents associated with the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("UserCount")]
                    [Validation(Required=false)]
                    public int? UserCount { get; set; }

                }

                /// <summary>
                /// <para>The usage of the phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bidirection</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

                /// <summary>
                /// <para>The agent ID. If this parameter is not empty, the phone number is a personal outbound phone number of the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2778FA12-EDD6-42AA-9B15-AF855072E5E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
