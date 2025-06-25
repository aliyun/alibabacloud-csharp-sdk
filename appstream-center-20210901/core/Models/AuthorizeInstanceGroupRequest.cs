// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AuthorizeInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>持久会话ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3mw2fg4j****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AuthorizeUserGroupIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserGroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of the users that you want to add to the authorization list of the delivery group. You can specify 1 to 100 user IDs.</para>
        /// </summary>
        [NameInMap("AuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("AvatarId")]
        [Validation(Required=false)]
        public string AvatarId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UnAuthorizeUserGroupIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserGroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of the users that you want to remove from the authorization list of the delivery group. You can specify 1 to 100 user IDs.</para>
        /// </summary>
        [NameInMap("UnAuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>The user information.</para>
        /// </summary>
        [NameInMap("UserMeta")]
        [Validation(Required=false)]
        public AuthorizeInstanceGroupRequestUserMeta UserMeta { get; set; }
        public class AuthorizeInstanceGroupRequestUserMeta : TeaModel {
            /// <summary>
            /// <para>The AD domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("AdDomain")]
            [Validation(Required=false)]
            public string AdDomain { get; set; }

            /// <summary>
            /// <para>The user type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ad: Active Directory (AD) account</description></item>
            /// <item><description>simple: convenience account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
