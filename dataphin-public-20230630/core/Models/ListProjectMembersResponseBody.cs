// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListProjectMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paging query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListProjectMembersResponseBodyPageResult PageResult { get; set; }
        public class ListProjectMembersResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of project members.</para>
            /// </summary>
            [NameInMap("ProjectMemberList")]
            [Validation(Required=false)]
            public List<ListProjectMembersResponseBodyPageResultProjectMemberList> ProjectMemberList { get; set; }
            public class ListProjectMembersResponseBodyPageResultProjectMemberList : TeaModel {
                /// <summary>
                /// <para>The creation timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1702692675000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The last modified timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1721720955000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12356</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101111</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The name of the user who last modified the record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试用户</para>
                /// </summary>
                [NameInMap("LastModifierName")]
                [Validation(Required=false)]
                public string LastModifierName { get; set; }

                /// <summary>
                /// <para>The roles.</para>
                /// </summary>
                [NameInMap("RoleIdList")]
                [Validation(Required=false)]
                public List<int?> RoleIdList { get; set; }

                /// <summary>
                /// <para>The user ID of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101111</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试用户</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The total number of project members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
