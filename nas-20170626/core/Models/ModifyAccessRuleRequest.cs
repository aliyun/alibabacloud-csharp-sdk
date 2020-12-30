// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAccessRuleRequest : TeaModel {
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        [NameInMap("AccessRuleId")]
        [Validation(Required=false)]
        public string AccessRuleId { get; set; }

        [NameInMap("SourceCidrIp")]
        [Validation(Required=false)]
        public string SourceCidrIp { get; set; }

        [NameInMap("RWAccessType")]
        [Validation(Required=false)]
        public string RWAccessType { get; set; }

        [NameInMap("UserAccessType")]
        [Validation(Required=false)]
        public string UserAccessType { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        [NameInMap("Ipv6SourceCidrIp")]
        [Validation(Required=false)]
        public string Ipv6SourceCidrIp { get; set; }

    }

}
