// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifySkillGroupOutboundNumbersRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public int? OperationType { get; set; }

        [NameInMap("OutboundPhoneNumberId")]
        [Validation(Required=false)]
        public List<string> OutboundPhoneNumberId { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

    }

}
