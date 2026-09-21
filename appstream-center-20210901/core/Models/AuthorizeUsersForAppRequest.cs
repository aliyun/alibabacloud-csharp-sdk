// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AuthorizeUsersForAppRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. The application must be deployed in the image used by the delivery group. You can obtain the ID from the Apps list returned by the <a href="https://help.aliyun.com/document_detail/600836.html">GetAppInstanceGroup</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-i87mycyn419nu****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The delivery group ID. You can call the <a href="https://help.aliyun.com/document_detail/428506.html">ListAppInstanceGroup</a> operation to obtain the ID.</para>
        /// <para>The application specified by AppId must be deployed in the image used by this delivery group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The list of usernames to add authorization for the application. A maximum of 100 usernames can be specified in a single request.</para>
        /// <para>At least one of AuthorizeUserIds and UnAuthorizeUserIds must be specified. You can also specify both. Adding authorization is subject to the authorized user quota for the application.</para>
        /// </summary>
        [NameInMap("AuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> AuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>The product type. Application-level authorization applies to WUYING Cloud Application delivery groups.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: WUYING Cloud Application.</description></item>
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
        /// <para>The list of usernames to be unauthorized for the application. A maximum of 100 usernames can be specified in a single request.</para>
        /// <para>At least one of AuthorizeUserIds and UnAuthorizeUserIds must be specified. You can also specify both. Removing authorizations is not subject to quota limits.</para>
        /// </summary>
        [NameInMap("UnAuthorizeUserIds")]
        [Validation(Required=false)]
        public List<string> UnAuthorizeUserIds { get; set; }

        /// <summary>
        /// <para>The account information of the authorized user, which specifies the account type corresponding to the username.</para>
        /// <list type="bullet">
        /// <item><description>If the workspace to which the delivery group belongs is an AD workspace, <b>this parameter is required</b>: set Type to ad and set AdDomain to the AD domain bound to the workspace.</description></item>
        /// <item><description>If this parameter is not specified, the WUYING convenience account (simple) is used by default.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("UserMeta")]
        [Validation(Required=false)]
        public AuthorizeUsersForAppRequestUserMeta UserMeta { get; set; }
        public class AuthorizeUsersForAppRequestUserMeta : TeaModel {
            /// <summary>
            /// <para>The AD domain name. Specify this parameter when Type is set to ad. The value must match the AD domain bound to the workspace of the delivery group.</para>
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
