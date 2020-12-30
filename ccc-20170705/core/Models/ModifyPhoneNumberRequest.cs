// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifyPhoneNumberRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PhoneNumberId")]
        [Validation(Required=false)]
        public string PhoneNumberId { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public List<string> SkillGroupId { get; set; }

    }

}
