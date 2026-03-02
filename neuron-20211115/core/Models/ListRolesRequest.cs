// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListRolesRequest : TeaModel {
        [NameInMap("authorizerId")]
        [Validation(Required=false)]
        public string AuthorizerId { get; set; }

        [NameInMap("authorizerType")]
        [Validation(Required=false)]
        public string AuthorizerType { get; set; }

        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("roleIds")]
        [Validation(Required=false)]
        public List<long?> RoleIds { get; set; }

        [NameInMap("roleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
