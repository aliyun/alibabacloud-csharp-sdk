// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListUsersResponseBody : TeaModel {
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
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataList> List { get; set; }
            public class ListUsersResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>SIP phone extension number. If the agent has registered a SIP phone, this parameter is the extension number of the SIP phone device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8033****</para>
                /// </summary>
                [NameInMap("DeviceExt")]
                [Validation(Required=false)]
                public string DeviceExt { get; set; }

                /// <summary>
                /// <para>Device ID, which is the identity of a browser-based Web Real-Time Communication (WebRTC) softphone or a physical phone device. Only one type of device can be registered at a time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACC-YUNBS-1.0.10-****</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <para>The status of the SIP phone device. If no SIP phone is registered, the status is UNREGISTERED (Unregistered). If a SIP phone is registered but offline, the status is OFFLINE (Offline). If a SIP phone is registered and online, the status is ONLINE (Online).</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFFLINE</para>
                /// </summary>
                [NameInMap("DeviceState")]
                [Validation(Required=false)]
                public string DeviceState { get; set; }

                /// <summary>
                /// <para>The agent\&quot;s employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("DisplayId")]
                [Validation(Required=false)]
                public string DisplayId { get; set; }

                /// <summary>
                /// <para>Agent display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>坐席小王</para>
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
                /// <para>The landline extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8031****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

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
                /// <para>List of personal outbound numbers for the agent.</para>
                /// </summary>
                [NameInMap("PersonalOutboundNumberList")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyDataListPersonalOutboundNumberList> PersonalOutboundNumberList { get; set; }
                public class ListUsersResponseBodyDataListPersonalOutboundNumberList : TeaModel {
                    /// <summary>
                    /// <para>Whether the number is active.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Active")]
                    [Validation(Required=false)]
                    public bool? Active { get; set; }

                    /// <summary>
                    /// <para>City where the number is registered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>乐山</para>
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// <para>Number.</para>
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
                    /// <para>Usage of the number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bidirection</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the RAM account mapped to the agent is a RAM root account.</para>
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// <para>Indicates whether the RAM account mapped to the agent is a RAM primary account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>已弃用，请使用Primary代替此参数。</para>
                /// </summary>
                [NameInMap("PrimaryAccount")]
                [Validation(Required=false)]
                public bool? PrimaryAccount { get; set; }

                /// <summary>
                /// <para>The UID of the Resource Access Management (RAM) user associated with the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21234502254620****</para>
                /// </summary>
                [NameInMap("RamId")]
                [Validation(Required=false)]
                public long? RamId { get; set; }

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
                /// <para>The role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Admin</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <para>The list of skill group levels associated with the agent.</para>
                /// </summary>
                [NameInMap("SkillLevelList")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyDataListSkillLevelList> SkillLevelList { get; set; }
                public class ListUsersResponseBodyDataListSkillLevelList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup@ccc-test</para>
                    /// </summary>
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    /// <summary>
                    /// <para>The name of the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup</para>
                    /// </summary>
                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                    /// <summary>
                    /// <para>The skill level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("SkillLevel")]
                    [Validation(Required=false)]
                    public int? SkillLevel { get; set; }

                }

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
            /// <para>1</para>
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
        /// <para>Response parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
