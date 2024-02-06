// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSIngestionConfiguration : TeaModel {
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public OSSIngestionConfigurationSource Source { get; set; }

    }

}
