// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateLangfuseUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateLangfuseUserResponseBodyData Data { get; set; }
        public class CreateLangfuseUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the user was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-04T10:20:33Z</para>
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
            /// <para>The role of the user.</para>
            /// </summary>
            [NameInMap("Membership")]
            [Validation(Required=false)]
            public CreateLangfuseUserResponseBodyDataMembership Membership { get; set; }
            public class CreateLangfuseUserResponseBodyDataMembership : TeaModel {
                /// <summary>
                /// <para>The Langfuse organization ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmrbhzx930005jw2q****</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <para>The role of the user in the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VIEWER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>john</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
