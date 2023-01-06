// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateApplicationResponseBody : TeaModel {
        [NameInMap("Application")]
        [Validation(Required=false)]
        public CreateApplicationResponseBodyApplication Application { get; set; }
        public class CreateApplicationResponseBodyApplication : TeaModel {
            [NameInMap("AccessTokenValidity")]
            [Validation(Required=false)]
            public int? AccessTokenValidity { get; set; }

            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public CreateApplicationResponseBodyApplicationDelegatedScope DelegatedScope { get; set; }
            public class CreateApplicationResponseBodyApplicationDelegatedScope : TeaModel {
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class CreateApplicationResponseBodyApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

            }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("IsMultiTenant")]
            [Validation(Required=false)]
            public bool? IsMultiTenant { get; set; }

            [NameInMap("RedirectUris")]
            [Validation(Required=false)]
            public CreateApplicationResponseBodyApplicationRedirectUris RedirectUris { get; set; }
            public class CreateApplicationResponseBodyApplicationRedirectUris : TeaModel {
                [NameInMap("RedirectUri")]
                [Validation(Required=false)]
                public List<string> RedirectUri { get; set; }

            }

            [NameInMap("RefreshTokenValidity")]
            [Validation(Required=false)]
            public int? RefreshTokenValidity { get; set; }

            [NameInMap("SecretRequired")]
            [Validation(Required=false)]
            public bool? SecretRequired { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
