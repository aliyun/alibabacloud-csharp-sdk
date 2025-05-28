// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns detailed information about the newly added Aliyun user.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddUserResponseBodyResult Result { get; set; }
        public class AddUserResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Aliyun account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxxxx@163.com">xxxxxx@163.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>Whether the organization administrator role is assigned. Value range: </para>
            /// <list type="bullet">
            /// <item><description>true: Yes</description></item>
            /// <item><description>false: No</description></item>
            /// </list>
            /// <para><notice>This parameter is deprecated and not recommended for use. It is invalid when RoleIdList is provided.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdminUser")]
            [Validation(Required=false)]
            public bool? AdminUser { get; set; }

            /// <summary>
            /// <para>Whether the permission administrator role is assigned. Value range: </para>
            /// <list type="bullet">
            /// <item><description>true: Yes</description></item>
            /// <item><description>false: No</description></item>
            /// </list>
            /// <para><notice>This parameter is deprecated and not recommended for use. It is invalid when RoleIdList is provided.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthAdminUser")]
            [Validation(Required=false)]
            public bool? AuthAdminUser { get; set; }

            /// <summary>
            /// <para>Aliyun account nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddd</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>List of organization role IDs bound to the user.</para>
            /// </summary>
            [NameInMap("RoleIdList")]
            [Validation(Required=false)]
            public List<long?> RoleIdList { get; set; }

            /// <summary>
            /// <para>UserID in Quick BI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b5d8fd9348cc4327****afb604</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>User type of the organization member. Value range: </para>
            /// <list type="bullet">
            /// <item><description>1: Developer </description></item>
            /// <item><description>2: Visitor </description></item>
            /// <item><description>3: Analyst</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
