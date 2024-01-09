// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class RegisterServersRequest : TeaModel {
        [NameInMap("AgentPort")]
        [Validation(Required=false)]
        public int? AgentPort { get; set; }

        [NameInMap("ServerInstancesInfo")]
        [Validation(Required=false)]
        public string ServerInstancesInfo { get; set; }

        [NameInMap("SitePairId")]
        [Validation(Required=false)]
        public string SitePairId { get; set; }

    }

}
