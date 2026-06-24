// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AuthorizeInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> operation to obtain the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The persistent session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3mw2fg4j****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>The list of user group IDs to be authorized.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AuthorizeUserGroupIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of usernames to be authorized for the delivery group. You can specify 1 to 100 usernames.</para>
        /// </summary>
        [NameInMap("AuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>The user avatar ID.</para>
        /// <remarks>
        /// <para>This parameter is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("AvatarId")]
        [Validation(Required=false)]
        public string AvatarId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of user group IDs to be deauthorized.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UnAuthorizeUserGroupIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of usernames to be deauthorized from the delivery group. You can specify 1 to 100 usernames.</para>
        /// </summary>
        [NameInMap("UnAuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>The user information.</para>
        /// </summary>
        [NameInMap("UserMeta")]
        [Validation(Required=false)]
        public string UserMetaShrink { get; set; }

    }

}
