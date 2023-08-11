// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// The information about the application.
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyApplications Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyApplicationsApplication> Application { get; set; }
            public class ListApplicationsResponseBodyApplicationsApplication : TeaModel {
                /// <summary>
                /// The validity period of the access token. Unit: seconds.
                /// </summary>
                [NameInMap("AccessTokenValidity")]
                [Validation(Required=false)]
                public int? AccessTokenValidity { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the application belongs.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The type of the application. Valid values:
                /// 
                /// *   WebApp: a web application.
                /// *   NativeApp: a native application that runs on an operating system, such as a desktop or mobile operating system.
                /// *   ServerApp: an application that can access Alibaba Cloud services without the need for user logon. Only applications that synchronize user information based on the System for Cross-domain Identity Management (SCIM) protocol are supported.
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The information about the permissions that are granted on the application.
                /// </summary>
                [NameInMap("DelegatedScope")]
                [Validation(Required=false)]
                public ListApplicationsResponseBodyApplicationsApplicationDelegatedScope DelegatedScope { get; set; }
                public class ListApplicationsResponseBodyApplicationsApplicationDelegatedScope : TeaModel {
                    /// <summary>
                    /// An array consisting of the information about the permissions that are granted on the application.
                    /// </summary>
                    [NameInMap("PredefinedScopes")]
                    [Validation(Required=false)]
                    public ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                    public class ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopes : TeaModel {
                        [NameInMap("PredefinedScope")]
                        [Validation(Required=false)]
                        public List<ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                        public class ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                            /// <summary>
                            /// The description of the permission.
                            /// </summary>
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                            /// <summary>
                            /// The name of the permission.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The display name of the application.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// Indicates whether the application can be installed by using other Alibaba Cloud accounts.
                /// </summary>
                [NameInMap("IsMultiTenant")]
                [Validation(Required=false)]
                public bool? IsMultiTenant { get; set; }

                /// <summary>
                /// The callback URL.
                /// </summary>
                [NameInMap("RedirectUris")]
                [Validation(Required=false)]
                public ListApplicationsResponseBodyApplicationsApplicationRedirectUris RedirectUris { get; set; }
                public class ListApplicationsResponseBodyApplicationsApplicationRedirectUris : TeaModel {
                    [NameInMap("RedirectUri")]
                    [Validation(Required=false)]
                    public List<string> RedirectUri { get; set; }

                }

                /// <summary>
                /// The validity period of the refresh token. Unit: seconds.
                /// </summary>
                [NameInMap("RefreshTokenValidity")]
                [Validation(Required=false)]
                public int? RefreshTokenValidity { get; set; }

                /// <summary>
                /// Indicates whether a secret is required.
                /// </summary>
                [NameInMap("SecretRequired")]
                [Validation(Required=false)]
                public bool? SecretRequired { get; set; }

                /// <summary>
                /// The update time.
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
