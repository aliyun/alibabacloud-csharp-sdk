// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateSkillGroupRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RoutingStrategy")]
        [Validation(Required=false)]
        public string RoutingStrategy { get; set; }

        [NameInMap("AllowPrivateOutboundNumber")]
        [Validation(Required=false)]
        public bool? AllowPrivateOutboundNumber { get; set; }

        [NameInMap("OutboundPhoneNumberId")]
        [Validation(Required=false)]
        public List<string> OutboundPhoneNumberId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public List<string> UserId { get; set; }

        [NameInMap("SkillLevel")]
        [Validation(Required=false)]
        public List<int?> SkillLevel { get; set; }

    }

}
