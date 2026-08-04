// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListClientUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>User information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListClientUsersResponseBodyData Data { get; set; }
        public class ListClientUsersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of user information.</para>
            /// </summary>
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListClientUsersResponseBodyDataDataList> DataList { get; set; }
            public class ListClientUsersResponseBodyDataDataList : TeaModel {
                /// <summary>
                /// <para>Department to which the user belongs.</para>
                /// </summary>
                [NameInMap("Department")]
                [Validation(Required=false)]
                public ListClientUsersResponseBodyDataDataListDepartment Department { get; set; }
                public class ListClientUsersResponseBodyDataDataListDepartment : TeaModel {
                    /// <summary>
                    /// <para>Department ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>105</para>
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
                /// <para>10800</para>
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
                /// <para>1970</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Custom identity source configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1026</para>
                /// </summary>
                [NameInMap("IdpConfigId")]
                [Validation(Required=false)]
                public string IdpConfigId { get; set; }

                /// <summary>
                /// <para>Mobile phone number without country code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15800820468</para>
                /// </summary>
                [NameInMap("MobileNumber")]
                [Validation(Required=false)]
                public string MobileNumber { get; set; }

                /// <summary>
                /// <para>User enable status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: disabled.</para>
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
                /// <para>Unique user identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_dead7216****</para>
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
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEF1144C-95D1-5F7C-81EF-9DB70EA49FCE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
