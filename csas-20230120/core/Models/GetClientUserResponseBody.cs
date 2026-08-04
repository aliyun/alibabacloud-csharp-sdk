// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetClientUserResponseBody : TeaModel {
        /// <summary>
        /// <para>User details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClientUserResponseBodyData Data { get; set; }
        public class GetClientUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Department to which the user belongs.</para>
            /// </summary>
            [NameInMap("Department")]
            [Validation(Required=false)]
            public GetClientUserResponseBodyDataDepartment Department { get; set; }
            public class GetClientUserResponseBodyDataDepartment : TeaModel {
                /// <summary>
                /// <para>Department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>107</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例部门</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10713</para>
            /// </summary>
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            /// <summary>
            /// <para>User description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例用户</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:johndoe@example.com">johndoe@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>ID of the custom identity source configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp-cfg68956d86e********</para>
            /// </summary>
            [NameInMap("IdpConfigId")]
            [Validation(Required=false)]
            public string IdpConfigId { get; set; }

            /// <summary>
            /// <para>Mobile phone number without country code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1364196****</para>
            /// </summary>
            [NameInMap("MobileNumber")]
            [Validation(Required=false)]
            public string MobileNumber { get; set; }

            /// <summary>
            /// <para>User status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Unique identifier of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_abcd7215****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
