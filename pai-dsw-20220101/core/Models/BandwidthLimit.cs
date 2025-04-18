// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class BandwidthLimit : TeaModel {
        [NameInMap("EgressRate")]
        [Validation(Required=false)]
        public string EgressRate { get; set; }

        [NameInMap("EgressWhitelists")]
        [Validation(Required=false)]
        public List<string> EgressWhitelists { get; set; }

        [NameInMap("IngressRate")]
        [Validation(Required=false)]
        public string IngressRate { get; set; }

        [NameInMap("IngressWhitelists")]
        [Validation(Required=false)]
        public List<string> IngressWhitelists { get; set; }

    }

}
