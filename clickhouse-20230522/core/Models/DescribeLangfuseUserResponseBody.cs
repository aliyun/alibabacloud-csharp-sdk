// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeLangfuseUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeLangfuseUserResponseBodyData Data { get; set; }
        public class DescribeLangfuseUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user is allowed to create an organization.</para>
            /// </summary>
            [NameInMap("AllowOrgCreation")]
            [Validation(Required=false)]
            public bool? AllowOrgCreation { get; set; }

            /// <summary>
            /// <para>The time when the user was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-01T10:03:05Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The email address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:john@company.com">john@company.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The role information of the user.</para>
            /// </summary>
            [NameInMap("Memberships")]
            [Validation(Required=false)]
            public List<DescribeLangfuseUserResponseBodyDataMemberships> Memberships { get; set; }
            public class DescribeLangfuseUserResponseBodyDataMemberships : TeaModel {
                /// <summary>
                /// <para>The role in the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADMIN</para>
                /// </summary>
                [NameInMap("OrgRole")]
                [Validation(Required=false)]
                public string OrgRole { get; set; }

                /// <summary>
                /// <para>The ID of the Langfuse organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmrbhzx930005jw2q****</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <para>The name of the Langfuse organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org_name</para>
                /// </summary>
                [NameInMap("OrganizationName")]
                [Validation(Required=false)]
                public string OrganizationName { get; set; }

                /// <summary>
                /// <para>The list of Langfuse projects.</para>
                /// </summary>
                [NameInMap("Projects")]
                [Validation(Required=false)]
                public List<DescribeLangfuseUserResponseBodyDataMembershipsProjects> Projects { get; set; }
                public class DescribeLangfuseUserResponseBodyDataMembershipsProjects : TeaModel {
                    /// <summary>
                    /// <para>The ID of the Langfuse project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cmrbhzx930005jw2q****</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <para>The name of the Langfuse project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>project_name</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                    /// <summary>
                    /// <para>The role in the project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VIEWER</para>
                    /// </summary>
                    [NameInMap("ProjectRole")]
                    [Validation(Required=false)]
                    public string ProjectRole { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>john</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the user was updated. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-01T10:03:05Z</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627FA5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
