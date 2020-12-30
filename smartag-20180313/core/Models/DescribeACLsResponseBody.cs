// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeACLsResponseBody : TeaModel {
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
        public DescribeACLsResponseBodyAcls Acls { get; set; }
        public class DescribeACLsResponseBodyAcls : TeaModel {
            [NameInMap("Acl")]
            [Validation(Required=false)]
            public List<DescribeACLsResponseBodyAclsAcl> Acl { get; set; }
            public class DescribeACLsResponseBodyAclsAcl : TeaModel {
                public string SagCount { get; set; }
                public string AclId { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
