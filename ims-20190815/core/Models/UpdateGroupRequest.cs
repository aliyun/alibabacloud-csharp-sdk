// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateGroupRequest : TeaModel {
        [NameInMap("GroupPrincipalName")]
        [Validation(Required=false)]
        public string GroupPrincipalName { get; set; }

        [NameInMap("NewGroupPrincipalName")]
        [Validation(Required=false)]
        public string NewGroupPrincipalName { get; set; }

        [NameInMap("NewComments")]
        [Validation(Required=false)]
        public string NewComments { get; set; }

        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        [NameInMap("AkProxySuffix")]
        [Validation(Required=false)]
        public string AkProxySuffix { get; set; }

        [NameInMap("NewGroupName")]
        [Validation(Required=false)]
        public string NewGroupName { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
