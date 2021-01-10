// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeUserlimitsettingsRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LimitRateKbytesPerSec")]
        [Validation(Required=false)]
        public string LimitRateKbytesPerSec { get; set; }

        [NameInMap("LimitReqPerSec")]
        [Validation(Required=false)]
        public string LimitReqPerSec { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
