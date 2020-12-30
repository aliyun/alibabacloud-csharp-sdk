// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessControlListsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Acls")]
        [Validation(Required=false)]
        public DescribeAccessControlListsResponseBodyAcls Acls { get; set; }
        public class DescribeAccessControlListsResponseBodyAcls : TeaModel {
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListsResponseBodyAclsAcl> Acl { get; set; }
            public class DescribeAccessControlListsResponseBodyAclsAcl : TeaModel {
                public string AclId { get; set; }
                public string AddressIPVersion { get; set; }
                public string ResourceGroupId { get; set; }
                public string AclName { get; set; }
            }
        };

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
