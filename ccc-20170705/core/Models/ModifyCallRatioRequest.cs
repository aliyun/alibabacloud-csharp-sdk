// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifyCallRatioRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

    }

}
