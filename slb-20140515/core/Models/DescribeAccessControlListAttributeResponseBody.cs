// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessControlListAttributeResponseBody : TeaModel {
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyAclEntrys AclEntrys { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyAclEntrys : TeaModel {
            [NameInMap("AclEntry")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry> AclEntry { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry : TeaModel {
                public string AclEntryComment { get; set; }
                public string AclEntryIP { get; set; }
            }
        };

        [NameInMap("RelatedListeners")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyRelatedListeners RelatedListeners { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyRelatedListeners : TeaModel {
            [NameInMap("RelatedListener")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyRelatedListenersRelatedListener> RelatedListener { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyRelatedListenersRelatedListener : TeaModel {
                public int? ListenerPort { get; set; }
                public string AclType { get; set; }
                public string Protocol { get; set; }
                public string LoadBalancerId { get; set; }
            }
        };

    }

}
