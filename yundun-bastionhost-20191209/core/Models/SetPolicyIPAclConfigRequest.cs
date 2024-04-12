// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyIPAclConfigRequest : TeaModel {
        [NameInMap("IPAclConfig")]
        [Validation(Required=false)]
        public SetPolicyIPAclConfigRequestIPAclConfig IPAclConfig { get; set; }
        public class SetPolicyIPAclConfigRequestIPAclConfig : TeaModel {
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            [NameInMap("IPs")]
            [Validation(Required=false)]
            public List<string> IPs { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
