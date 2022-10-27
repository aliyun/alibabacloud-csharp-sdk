// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetPostScriptsResponseBody : TeaModel {
        [NameInMap("PostInstallScripts")]
        [Validation(Required=false)]
        public List<GetPostScriptsResponseBodyPostInstallScripts> PostInstallScripts { get; set; }
        public class GetPostScriptsResponseBodyPostInstallScripts : TeaModel {
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
