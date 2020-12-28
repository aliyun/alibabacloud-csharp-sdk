// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessControlListAttributeResponseBody : TeaModel {
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public List<DescribeAccessControlListAttributeResponseBodyAclEntrys> AclEntrys { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyAclEntrys : TeaModel {
            [NameInMap("AclEntryComment")]
            [Validation(Required=false)]
            public string AclEntryComment { get; set; }

            [NameInMap("AclEntryIP")]
            [Validation(Required=false)]
            public string AclEntryIP { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        [NameInMap("RelatedListeners")]
        [Validation(Required=false)]
        public List<DescribeAccessControlListAttributeResponseBodyRelatedListeners> RelatedListeners { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyRelatedListeners : TeaModel {
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

        }

        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

    }

}
