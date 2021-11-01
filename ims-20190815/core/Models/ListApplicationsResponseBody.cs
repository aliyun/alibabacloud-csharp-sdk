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
                public int? AccessTokenValidity { get; set; }
                public string AccountId { get; set; }
                public string AppId { get; set; }
                public string AppName { get; set; }
                public string AppType { get; set; }
                public string CreateDate { get; set; }
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
                            public string Description { get; set; }
                            public string Name { get; set; }
                        }
                    };

                }
                public string DisplayName { get; set; }
                public bool? IsMultiTenant { get; set; }
                public ListApplicationsResponseBodyApplicationsApplicationRedirectUris RedirectUris { get; set; }
                public class ListApplicationsResponseBodyApplicationsApplicationRedirectUris : TeaModel {
                    [NameInMap("RedirectUri")]
                    [Validation(Required=false)]
                    public List<string> RedirectUri { get; set; }

                }
                public int? RefreshTokenValidity { get; set; }
                public bool? SecretRequired { get; set; }
                public string UpdateDate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
