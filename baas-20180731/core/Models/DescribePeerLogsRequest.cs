// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribePeerLogsRequest : TeaModel {
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public string Lines { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("PeerName")]
        [Validation(Required=false)]
        public string PeerName { get; set; }

    }

}
