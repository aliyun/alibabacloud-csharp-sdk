// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeFabricChaincodeLogsRequest : TeaModel {
        [NameInMap("ChaincodeId")]
        [Validation(Required=false)]
        public string ChaincodeId { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public string Lines { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("PeerName")]
        [Validation(Required=false)]
        public string PeerName { get; set; }

    }

}
