// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclsResponseBody : TeaModel {
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<ListAclsResponseBodyAcls> Acls { get; set; }
        public class ListAclsResponseBodyAcls : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            [NameInMap("AclName")]
            [Validation(Required=false)]
            public string AclName { get; set; }

            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            [NameInMap("AddressIPVersion")]
            [Validation(Required=false)]
            public string AddressIPVersion { get; set; }

            [NameInMap("ConfigManagedEnabled")]
            [Validation(Required=false)]
            public bool? ConfigManagedEnabled { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
