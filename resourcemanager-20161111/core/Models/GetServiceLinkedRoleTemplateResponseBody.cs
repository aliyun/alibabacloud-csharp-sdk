// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class GetServiceLinkedRoleTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceLinkedRoleTemplate")]
        [Validation(Required=false)]
        public GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplate ServiceLinkedRoleTemplate { get; set; }
        public class GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplate : TeaModel {
            [NameInMap("MultipleRolesAllowed")]
            [Validation(Required=false)]
            public bool? MultipleRolesAllowed { get; set; }

            [NameInMap("RoleDescriptions")]
            [Validation(Required=false)]
            public GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptions RoleDescriptions { get; set; }
            public class GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptions : TeaModel {
                [NameInMap("RoleDescription")]
                [Validation(Required=false)]
                public List<GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptionsRoleDescription> RoleDescription { get; set; }
                public class GetServiceLinkedRoleTemplateResponseBodyServiceLinkedRoleTemplateRoleDescriptionsRoleDescription : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                }

            }

            [NameInMap("RoleNamePrefix")]
            [Validation(Required=false)]
            public string RoleNamePrefix { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("SystemPolicyName")]
            [Validation(Required=false)]
            public string SystemPolicyName { get; set; }

        }

    }

}
