// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ProvisionExternalApplicationResponseBody : TeaModel {
        [NameInMap("ExternalApplication")]
        [Validation(Required=false)]
        public ProvisionExternalApplicationResponseBodyExternalApplication ExternalApplication { get; set; }
        public class ProvisionExternalApplicationResponseBodyExternalApplication : TeaModel {
            [NameInMap("AppPrincipalName")]
            [Validation(Required=false)]
            public string AppPrincipalName { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("DelegatedScope")]
            [Validation(Required=false)]
            public ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScope DelegatedScope { get; set; }
            public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScope : TeaModel {
                [NameInMap("PredefinedScopes")]
                [Validation(Required=false)]
                public ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes PredefinedScopes { get; set; }
                public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopes : TeaModel {
                    [NameInMap("PredefinedScope")]
                    [Validation(Required=false)]
                    public List<ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope> PredefinedScope { get; set; }
                    public class ProvisionExternalApplicationResponseBodyExternalApplicationDelegatedScopePredefinedScopesPredefinedScope : TeaModel {
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

            [NameInMap("ForeignAppId")]
            [Validation(Required=false)]
            public string ForeignAppId { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
