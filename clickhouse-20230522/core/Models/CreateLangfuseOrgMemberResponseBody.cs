// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateLangfuseOrgMemberResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the user added to the Langfuse organization.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateLangfuseOrgMemberResponseBodyData Data { get; set; }
        public class CreateLangfuseOrgMemberResponseBodyData : TeaModel {
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
