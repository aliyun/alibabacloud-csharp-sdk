// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorAclListAttributesResponseBody : TeaModel {
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntries AclEntries { get; set; }
        public class DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntries : TeaModel {
            [NameInMap("AclEntry")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntriesAclEntry> AclEntry { get; set; }
            public class DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntriesAclEntry : TeaModel {
                public string AclEntryComment { get; set; }
                public string AclEntryId { get; set; }
                public string AclEntryIp { get; set; }
            }
        };

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
