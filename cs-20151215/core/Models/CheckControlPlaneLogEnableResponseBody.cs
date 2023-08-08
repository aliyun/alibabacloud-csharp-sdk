// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CheckControlPlaneLogEnableResponseBody : TeaModel {
        [NameInMap("aliuid")]
        [Validation(Required=false)]
        public string Aliuid { get; set; }

        [NameInMap("components")]
        [Validation(Required=false)]
        public List<string> Components { get; set; }

        [NameInMap("log_project")]
        [Validation(Required=false)]
        public string LogProject { get; set; }

        [NameInMap("log_ttl")]
        [Validation(Required=false)]
        public string LogTtl { get; set; }

    }

}
