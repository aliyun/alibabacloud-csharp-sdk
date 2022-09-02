// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAccessControlListAttributeResponseBody : TeaModel {
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyAclEntrys AclEntrys { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyAclEntrys : TeaModel {
            [NameInMap("AclEntry")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry> AclEntry { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry : TeaModel {
                [NameInMap("AclEntryComment")]
                [Validation(Required=false)]
                public string AclEntryComment { get; set; }

                [NameInMap("AclEntryIp")]
                [Validation(Required=false)]
                public string AclEntryIp { get; set; }

            }

        }

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        [NameInMap("IsUsed")]
        [Validation(Required=false)]
        public string IsUsed { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
