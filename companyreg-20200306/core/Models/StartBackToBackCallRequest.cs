// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class StartBackToBackCallRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CallCenterNumber")]
        [Validation(Required=false)]
        public string CallCenterNumber { get; set; }

        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("MobileKey")]
        [Validation(Required=false)]
        public string MobileKey { get; set; }

        [NameInMap("SkillType")]
        [Validation(Required=false)]
        public long? SkillType { get; set; }

    }

}
