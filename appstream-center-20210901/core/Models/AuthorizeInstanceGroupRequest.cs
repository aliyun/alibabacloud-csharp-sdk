// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AuthorizeInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>交付群組 ID。可呼叫 <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> 介面取得。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>持續性工作階段 ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3mw2fg4j****</para>
        /// </summary>
        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <para>授權使用者群組 ID 清單。</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AuthorizeUserGroupIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserGroupIds { get; set; }

        /// <summary>
        /// <para>要新增交付群組授權的使用者名稱清單。可設定 1\~100 個。</para>
        /// </summary>
        [NameInMap("AuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>使用者分身 ID。</para>
        /// <remarks>
        /// <para>此參數未開放使用。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("AvatarId")]
        [Validation(Required=false)]
        public string AvatarId { get; set; }

        /// <summary>
        /// <para>產品類型。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>取消授權使用者群組 ID 清單。</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UnAuthorizeUserGroupIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserGroupIds { get; set; }

        /// <summary>
        /// <para>要移除交付群組授權的使用者名稱清單。可設定 1\~100 個。</para>
        /// </summary>
        [NameInMap("UnAuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>使用者資訊。</para>
        /// </summary>
        [NameInMap("UserMeta")]
        [Validation(Required=false)]
        public AuthorizeInstanceGroupRequestUserMeta UserMeta { get; set; }
        public class AuthorizeInstanceGroupRequestUserMeta : TeaModel {
            /// <summary>
            /// <para>AD 網域名稱。</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("AdDomain")]
            [Validation(Required=false)]
            public string AdDomain { get; set; }

            /// <summary>
            /// <para>使用者類型。</para>
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
