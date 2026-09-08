// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListInstancesOfUserResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesOfUserResponseBodyData Data { get; set; }
        public class ListInstancesOfUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListInstancesOfUserResponseBodyDataList> List { get; set; }
            public class ListInstancesOfUserResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Administrator list.</para>
                /// </summary>
                [NameInMap("AdminList")]
                [Validation(Required=false)]
                public List<ListInstancesOfUserResponseBodyDataListAdminList> AdminList { get; set; }
                public class ListInstancesOfUserResponseBodyDataListAdminList : TeaModel {
                    /// <summary>
                    /// <para>The administrator\&quot;s name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试坐席</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>Mailbox.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                    /// </summary>
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    /// <summary>
                    /// <para>Agent extension number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8032****</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <para>Instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ccc-test</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>Agent logon name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent</para>
                    /// </summary>
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    /// <summary>
                    /// <para>The agent\&quot;s personal phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1382114****</para>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    /// <summary>
                    /// <para>The role ID, in the format: role\@instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Admin@ccc-test</para>
                    /// </summary>
                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public string RoleId { get; set; }

                    /// <summary>
                    /// <para>Role name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Admin</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                    /// <summary>
                    /// <para>Agent ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>Work mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ON_SITE</para>
                    /// </summary>
                    [NameInMap("WorkMode")]
                    [Validation(Required=false)]
                    public string WorkMode { get; set; }

                }

                /// <summary>
                /// <para>The Alibaba Cloud Account ID to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>157123456789****</para>
                /// </summary>
                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                /// <summary>
                /// <para>The URL of the Cloud Contact Center instance, used to access the homepage of the Cloud Contact Center instance. It consists of the specific Cloud Contact Center URL followed by the instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://ccc-v2.aliyun.com/#/workbench/ccc-test">https://ccc-v2.aliyun.com/#/workbench/ccc-test</a></para>
                /// </summary>
                [NameInMap("ConsoleUrl")]
                [Validation(Required=false)]
                public string ConsoleUrl { get; set; }

                /// <summary>
                /// <para>The instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云联络中心的测试实例。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The domain name of the instance, which is globally unique.</para>
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
                /// <para>测试实例</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>List of numbers.</para>
                /// </summary>
                [NameInMap("NumberList")]
                [Validation(Required=false)]
                public List<ListInstancesOfUserResponseBodyDataListNumberList> NumberList { get; set; }
                public class ListInstancesOfUserResponseBodyDataListNumberList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the number is active.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Active")]
                    [Validation(Required=false)]
                    public bool? Active { get; set; }

                    /// <summary>
                    /// <para>The city of the phone number\&quot;s registration location.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>乐山</para>
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// <para>The contact flow ID (IVR) associated with this phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a3fb6c62-9b49-4942-ae5b-cf2abd4123ek</para>
                    /// </summary>
                    [NameInMap("ContactFlowId")]
                    [Validation(Required=false)]
                    public string ContactFlowId { get; set; }

                    /// <summary>
                    /// <para>Instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ccc-test</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0830011****</para>
                    /// </summary>
                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    /// <summary>
                    /// <para>The province of the phone number\&quot;s registration location.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>四川</para>
                    /// </summary>
                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    /// <summary>
                    /// <para>List of skill groups associated with the phone number.</para>
                    /// </summary>
                    [NameInMap("SkillGroups")]
                    [Validation(Required=false)]
                    public List<ListInstancesOfUserResponseBodyDataListNumberListSkillGroups> SkillGroups { get; set; }
                    public class ListInstancesOfUserResponseBodyDataListNumberListSkillGroups : TeaModel {
                        /// <summary>
                        /// <para>Skill group description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>云联络中心的测试技能组。</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The display name of the skill group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>测试技能组</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>Instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ccc-test</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The name of the skill group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>skillgroup</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Number of phone numbers associated with the skill group.</para>
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
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("UserCount")]
                        [Validation(Required=false)]
                        public int? UserCount { get; set; }

                    }

                    /// <summary>
                    /// <para>The usage of the number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bidirection</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                    /// <summary>
                    /// <para>Agent ID. If this parameter is not empty, the number is a personal outbound number assigned to the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>Instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3969FC68-CEC2-4398-B76A-60D2F7EDEBAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
