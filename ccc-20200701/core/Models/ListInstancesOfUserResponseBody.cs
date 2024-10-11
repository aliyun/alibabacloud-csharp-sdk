// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListInstancesOfUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesOfUserResponseBodyData Data { get; set; }
        public class ListInstancesOfUserResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListInstancesOfUserResponseBodyDataList> List { get; set; }
            public class ListInstancesOfUserResponseBodyDataList : TeaModel {
                [NameInMap("AdminList")]
                [Validation(Required=false)]
                public List<ListInstancesOfUserResponseBodyDataListAdminList> AdminList { get; set; }
                public class ListInstancesOfUserResponseBodyDataListAdminList : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                    /// </summary>
                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8032****</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ccc-test</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent</para>
                    /// </summary>
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1382114****</para>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Admin@ccc-test</para>
                    /// </summary>
                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public string RoleId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Admin</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ON_SITE</para>
                    /// </summary>
                    [NameInMap("WorkMode")]
                    [Validation(Required=false)]
                    public string WorkMode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>157123456789****</para>
                /// </summary>
                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://ccc-v2.aliyun.com/#/workbench/ccc-test">https://ccc-v2.aliyun.com/#/workbench/ccc-test</a></para>
                /// </summary>
                [NameInMap("ConsoleUrl")]
                [Validation(Required=false)]
                public string ConsoleUrl { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NumberList")]
                [Validation(Required=false)]
                public List<ListInstancesOfUserResponseBodyDataListNumberList> NumberList { get; set; }
                public class ListInstancesOfUserResponseBodyDataListNumberList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Active")]
                    [Validation(Required=false)]
                    public bool? Active { get; set; }

                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a3fb6c62-9b49-4942-ae5b-cf2abd4123ek</para>
                    /// </summary>
                    [NameInMap("ContactFlowId")]
                    [Validation(Required=false)]
                    public string ContactFlowId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ccc-test</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0830011****</para>
                    /// </summary>
                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    [NameInMap("SkillGroups")]
                    [Validation(Required=false)]
                    public List<ListInstancesOfUserResponseBodyDataListNumberListSkillGroups> SkillGroups { get; set; }
                    public class ListInstancesOfUserResponseBodyDataListNumberListSkillGroups : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ccc-test</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>skillgroup</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("PhoneNumberCount")]
                        [Validation(Required=false)]
                        public int? PhoneNumberCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>skillgroup@ccc-test</para>
                        /// </summary>
                        [NameInMap("SkillGroupId")]
                        [Validation(Required=false)]
                        public string SkillGroupId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("UserCount")]
                        [Validation(Required=false)]
                        public int? UserCount { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Bidirection</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent@ccc-test</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3969FC68-CEC2-4398-B76A-60D2F7EDEBAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
