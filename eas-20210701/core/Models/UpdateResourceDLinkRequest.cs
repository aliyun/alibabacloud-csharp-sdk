// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceDLinkRequest : TeaModel {
        [NameInMap("DestinationCIDRs")]
        [Validation(Required=false)]
        public string DestinationCIDRs { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("VSwitchIdList")]
        [Validation(Required=false)]
        public List<string> VSwitchIdList { get; set; }

    }

}
