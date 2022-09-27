// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateLogstashRequest : TeaModel {
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public int? NodeAmount { get; set; }

        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public UpdateLogstashRequestNodeSpec NodeSpec { get; set; }
        public class UpdateLogstashRequestNodeSpec : TeaModel {
            [NameInMap("disk")]
            [Validation(Required=false)]
            public int? Disk { get; set; }

            [NameInMap("diskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
