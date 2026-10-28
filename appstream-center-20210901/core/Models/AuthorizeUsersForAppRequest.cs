// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AuthorizeUsersForAppRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. The application must be deployed in the image used by the app instance group. You can obtain the application ID from the Apps list returned by the <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the app instance group. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> operation to query the ID.</para>
        /// <para>The application specified by AppId must be deployed in the image used by the app instance group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The list of usernames of the users to be authorized for the application. You can specify up to 100 usernames in a single call.</para>
        /// <para>You must specify at least one of AuthorizeUserIds and UnAuthorizeUserIds, or specify both. Adding authorization is subject to the authorized user quota limit of the application.</para>
        /// </summary>
        [NameInMap("AuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>The product type. Application-level authorization applies to WUYING Cloud App app instance groups.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: WUYING Cloud App.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of usernames of the users whose authorization for the application is to be removed. You can specify up to 100 usernames in a single call.</para>
        /// <para>You must specify at least one of AuthorizeUserIds and UnAuthorizeUserIds, or specify both. Removing authorization is not subject to quota limits.</para>
        /// </summary>
        [NameInMap("UnAuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>The account information of the authorized user, which is used to specify the account type corresponding to the username.</para>
        /// <list type="bullet">
        /// <item><description><b>Required</b> if the workspace to which the app instance group belongs is an AD workspace: Set Type to ad, and set AdDomain to the AD domain bound to the workspace.</description></item>
        /// <item><description>If this parameter is not specified, the default account type is WUYING convenience account (simple).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("UserMeta")]
        [Validation(Required=false)]
        public AuthorizeUsersForAppRequestUserMeta UserMeta { get; set; }
        public class AuthorizeUsersForAppRequestUserMeta : TeaModel {
            /// <summary>
            /// <para>The AD domain name. This parameter is required when Type is set to ad, and the value must be the same as the AD domain bound to the workspace to which the app instance group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("AdDomain")]
            [Validation(Required=false)]
            public string AdDomain { get; set; }

            /// <summary>
            /// <para>The account type. Default value: simple.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ad: AD account.</description></item>
            /// <item><description>simple: WUYING convenience account.</description></item>
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
