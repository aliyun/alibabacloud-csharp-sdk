// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorAclListAttributesResponseBody : TeaModel {
        /// <summary>
        /// The ACLs.
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntries AclEntries { get; set; }
        public class DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntries : TeaModel {
            [NameInMap("AclEntry")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntriesAclEntry> AclEntry { get; set; }
            public class DescribeIPv6TranslatorAclListAttributesResponseBodyAclEntriesAclEntry : TeaModel {
                /// <summary>
                /// The remarks of the ACL entry.
                /// </summary>
                [NameInMap("AclEntryComment")]
                [Validation(Required=false)]
                public string AclEntryComment { get; set; }

                /// <summary>
                /// The ID of the ACL entry.
                /// </summary>
                [NameInMap("AclEntryId")]
                [Validation(Required=false)]
                public string AclEntryId { get; set; }

                /// <summary>
                /// The IP address specified in the ACL entry.
                /// </summary>
                [NameInMap("AclEntryIp")]
                [Validation(Required=false)]
                public string AclEntryIp { get; set; }

            }

        }

        /// <summary>
        /// The ACL ID.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// The name of the ACL.
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
