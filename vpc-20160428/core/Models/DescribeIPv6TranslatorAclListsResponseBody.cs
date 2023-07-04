// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorAclListsResponseBody : TeaModel {
        /// <summary>
        /// The list of network ACLs.
        /// </summary>
        [NameInMap("Ipv6TranslatorAcls")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAcls Ipv6TranslatorAcls { get; set; }
        public class DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAcls : TeaModel {
            [NameInMap("IPv6TranslatorAcl")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAclsIPv6TranslatorAcl> IPv6TranslatorAcl { get; set; }
            public class DescribeIPv6TranslatorAclListsResponseBodyIpv6TranslatorAclsIPv6TranslatorAcl : TeaModel {
                /// <summary>
                /// The ACL ID.
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// The ACL name.
                /// </summary>
                [NameInMap("AclName")]
                [Validation(Required=false)]
                public string AclName { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
