// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDomainShrinkRequest : TeaModel {
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Listen")]
        [Validation(Required=false)]
        public string ListenShrink { get; set; }

        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public string RedirectShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
