// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the newly added Alibaba Cloud user.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddUserResponseBodyResult Result { get; set; }
        public class AddUserResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxxxx@163.com">xxxxxx@163.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>Indicates whether the organization administrator role is assigned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter is deprecated. It does not take effect when <c>RoleIdList</c> is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdminUser")]
            [Validation(Required=false)]
            public bool? AdminUser { get; set; }

            /// <summary>
            /// <para>Indicates whether the permission administrator role is assigned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter is deprecated. It does not take effect when <c>RoleIdList</c> is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthAdminUser")]
            [Validation(Required=false)]
            public bool? AuthAdminUser { get; set; }

            /// <summary>
            /// <para>The Copilot modules for which the user has a quota.</para>
            /// </summary>
            [NameInMap("CopilotModules")]
            [Validation(Required=false)]
            public List<string> CopilotModules { get; set; }

            /// <summary>
            /// <para>The nickname of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>A list of organization role IDs assigned to the user.</para>
            /// </summary>
            [NameInMap("RoleIdList")]
            [Validation(Required=false)]
            public List<long?> RoleIdList { get; set; }

            /// <summary>
            /// <para>The user ID in Quick BI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b5d8fd9348cc4327****afb604</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The user type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: developer</para>
            /// </description></item>
            /// <item><description><para>2: viewer</para>
            /// </description></item>
            /// <item><description><para>3: analyst</para>
            /// </description></item>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
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
