// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeExternswebhookRequest : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("GitlabEvent")]
        [Validation(Required=false)]
        public string GitlabEvent { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
