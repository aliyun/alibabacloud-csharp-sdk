// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUsersResponseBodyData Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyDataList> List { get; set; }
            public class ListUsersResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8033****</para>
                /// </summary>
                [NameInMap("DeviceExt")]
                [Validation(Required=false)]
                public string DeviceExt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACC-YUNBS-1.0.10-****</para>
                /// </summary>
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OFFLINE</para>
                /// </summary>
                [NameInMap("DeviceState")]
                [Validation(Required=false)]
                public string DeviceState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("DisplayId")]
                [Validation(Required=false)]
                public string DisplayId { get; set; }

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
                /// <para>8031****</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

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

                [NameInMap("PersonalOutboundNumberList")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyDataListPersonalOutboundNumberList> PersonalOutboundNumberList { get; set; }
                public class ListUsersResponseBodyDataListPersonalOutboundNumberList : TeaModel {
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
                    /// <para>0830011****</para>
                    /// </summary>
                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Bidirection</para>
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("PrimaryAccount")]
                [Validation(Required=false)]
                public bool? PrimaryAccount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>21234502254620****</para>
                /// </summary>
                [NameInMap("RamId")]
                [Validation(Required=false)]
                public long? RamId { get; set; }

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

                [NameInMap("SkillLevelList")]
                [Validation(Required=false)]
                public List<ListUsersResponseBodyDataListSkillLevelList> SkillLevelList { get; set; }
                public class ListUsersResponseBodyDataListSkillLevelList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>skillgroup@ccc-test</para>
                    /// </summary>
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>skillgroup</para>
                    /// </summary>
                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("SkillLevel")]
                    [Validation(Required=false)]
                    public int? SkillLevel { get; set; }

                }

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
            /// <para>1</para>
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

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
