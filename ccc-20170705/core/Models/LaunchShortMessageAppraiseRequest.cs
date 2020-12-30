// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class LaunchShortMessageAppraiseRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        [NameInMap("ContactType")]
        [Validation(Required=false)]
        public int? ContactType { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public string PhoneNumbers { get; set; }

    }

}
