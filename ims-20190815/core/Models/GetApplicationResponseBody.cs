// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The validity period of the access token. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("AccessTokenValidity")]
            [Validation(Required=false)]
            public int? AccessTokenValidity { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177242285274****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>472457090344041****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myapp</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WebApp: a web application.</description></item>
            /// <item><description>NativeApp: a native application that runs on an operating system, such as a desktop or mobile operating system.</description></item>
            /// <item><description>ServerApp: an application that can access Alibaba Cloud services without the need for user logon. Only applications that synchronize user information based on the System for Cross-domain Identity Management (SCIM) protocol are supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WebApp</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-23T08:06:57Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The information about the permissions that are granted on the application.</para>
            /// </summary>
            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyApplicationDelegatedScope DelegatedScope { get; set; }
            public class GetApplicationResponseBodyApplicationDelegatedScope : TeaModel {
                /// <summary>
                /// <para>The information about the permissions that are granted on the application.</para>
                /// </summary>
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public GetApplicationResponseBodyApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class GetApplicationResponseBodyApplicationDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<GetApplicationResponseBodyApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class GetApplicationResponseBodyApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                        /// <summary>
                        /// <para>The description of the permission.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Obtain the OpenID of the user. This is the default permission that you cannot remove.</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The name of the permission.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>openid</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the permission is automatically selected by default when you install the application. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true</description></item>
                        /// <item><description>false</description></item>
                        /// </list>
                        /// <para><c>openid</c> is required by default.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The display name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myapp</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Indicates whether the application can be installed by using other Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsMultiTenant")]
            [Validation(Required=false)]
            public bool? IsMultiTenant { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// </summary>
            [NameInMap("RedirectUris")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyApplicationRedirectUris RedirectUris { get; set; }
            public class GetApplicationResponseBodyApplicationRedirectUris : TeaModel {
                [NameInMap("RedirectUri")]
                [Validation(Required=false)]
                public List<string> RedirectUri { get; set; }

            }

            /// <summary>
            /// <para>The validity period of the refresh token. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7776000</para>
            /// </summary>
            [NameInMap("RefreshTokenValidity")]
            [Validation(Required=false)]
            public int? RefreshTokenValidity { get; set; }

            /// <summary>
            /// <para>Indicates whether a secret is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SecretRequired")]
            [Validation(Required=false)]
            public bool? SecretRequired { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-23T08:06:57Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6616F09B-2768-4C11-8866-A8EE4C4A583E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
