// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public ListApplicationsResponseBodyApplications Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<ListApplicationsResponseBodyApplicationsApplication> Application { get; set; }
            public class ListApplicationsResponseBodyApplicationsApplication : TeaModel {
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
                public ListApplicationsResponseBodyApplicationsApplicationDelegatedScope DelegatedScope { get; set; }
                public class ListApplicationsResponseBodyApplicationsApplicationDelegatedScope : TeaModel {
                    [NameInMap("PredefinedScopes")]
                    [Validation(Required=false)]
                    public ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                    public class ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopes : TeaModel {
                        [NameInMap("PredefinedScope")]
                        [Validation(Required=false)]
                        public List<ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                        public class ListApplicationsResponseBodyApplicationsApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
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
                public ListApplicationsResponseBodyApplicationsApplicationRedirectUris RedirectUris { get; set; }
                public class ListApplicationsResponseBodyApplicationsApplicationRedirectUris : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
