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
            /// <para>Indicates whether the organization administrator role is bound. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// <para><notice>This parameter is deprecated. When RoleIdList is specified, this parameter does not take effect.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdminUser")]
            [Validation(Required=false)]
            public bool? AdminUser { get; set; }

            /// <summary>
            /// <para>Indicates whether the permission management administrator role is attached. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// <para><notice>This parameter has expired and is no longer recommended. When RoleIdList is specified, this parameter does not take effect.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthAdminUser")]
            [Validation(Required=false)]
            public bool? AuthAdminUser { get; set; }

            /// <summary>
            /// <para>The intelligent module quotas owned by the user.</para>
            /// </summary>
            [NameInMap("CopilotModules")]
            [Validation(Required=false)]
            public List<string> CopilotModules { get; set; }

            /// <summary>
            /// <para>The nickname of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The list of organization role IDs bound to the user.</para>
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
            /// <para>The user type of the organization member. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Developer.</description></item>
            /// <item><description>2: Visitor.</description></item>
            /// <item><description>3: Analyst.</description></item>
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
