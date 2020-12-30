// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorAclListsResponseBody : TeaModel {
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

        [NameInMap("Ipv6TranslatorAcls")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAcls Ipv6TranslatorAcls { get; set; }
        public class DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAcls : TeaModel {
            [NameInMap("IPv6TranslatorAcl")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAclsIPv6TranslatorAcl> IPv6TranslatorAcl { get; set; }
            public class DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAclsIPv6TranslatorAcl : TeaModel {
                public string AclId { get; set; }
                public string AclName { get; set; }
            }
        };

    }

}
