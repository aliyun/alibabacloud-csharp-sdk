// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeTenantrecoverytaskRequest : TeaModel {
        [NameInMap("AntcodeTarget")]
        [Validation(Required=false)]
        public string AntcodeTarget { get; set; }

        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
