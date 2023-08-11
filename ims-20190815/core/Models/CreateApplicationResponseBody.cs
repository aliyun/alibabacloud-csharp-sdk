// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateApplicationResponseBody : TeaModel {
        /// <summary>
        /// The information of the application.
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public CreateApplicationResponseBodyApplication Application { get; set; }
        public class CreateApplicationResponseBodyApplication : TeaModel {
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
            /// The type of the application.
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
            /// The information of application permissions.
            /// </summary>
            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public CreateApplicationResponseBodyApplicationDelegatedScope DelegatedScope { get; set; }
            public class CreateApplicationResponseBodyApplicationDelegatedScope : TeaModel {
                /// <summary>
                /// The information of application permissions.
                /// </summary>
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                        /// <summary>
                        /// The description of the permission scope.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The name of the scope.
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
            public CreateApplicationResponseBodyApplicationRedirectUris RedirectUris { get; set; }
            public class CreateApplicationResponseBodyApplicationRedirectUris : TeaModel {
                [NameInMap("RedirectUri")]
                [Validation(Required=false)]
                public List<string> RedirectUri { get; set; }

            }

            /// <summary>
            /// The validity period of the refreshed token. Unit: seconds.
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
