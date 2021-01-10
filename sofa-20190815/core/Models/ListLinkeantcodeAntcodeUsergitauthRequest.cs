// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeantcodeAntcodeUsergitauthRequest : TeaModel {
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
