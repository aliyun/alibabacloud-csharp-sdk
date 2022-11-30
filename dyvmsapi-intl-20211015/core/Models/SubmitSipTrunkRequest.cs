// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class SubmitSipTrunkRequest : TeaModel {
        [NameInMap("ApplyNote")]
        [Validation(Required=false)]
        public string ApplyNote { get; set; }

        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        [NameInMap("InboundIpPorts")]
        [Validation(Required=false)]
        public string InboundIpPorts { get; set; }

        [NameInMap("OutboundIps")]
        [Validation(Required=false)]
        public string OutboundIps { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public string QualificationId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
