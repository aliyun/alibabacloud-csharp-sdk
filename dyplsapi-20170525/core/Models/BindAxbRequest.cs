// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxbRequest : TeaModel {
        [NameInMap("ASRModelId")]
        [Validation(Required=false)]
        public string ASRModelId { get; set; }

        [NameInMap("ASRStatus")]
        [Validation(Required=false)]
        public bool? ASRStatus { get; set; }

        [NameInMap("CallDisplayType")]
        [Validation(Required=false)]
        public int? CallDisplayType { get; set; }

        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        [NameInMap("CallTimeout")]
        [Validation(Required=false)]
        public int? CallTimeout { get; set; }

        [NameInMap("DtmfConfig")]
        [Validation(Required=false)]
        public string DtmfConfig { get; set; }

        [NameInMap("ExpectCity")]
        [Validation(Required=false)]
        public string ExpectCity { get; set; }

        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("IsRecordingEnabled")]
        [Validation(Required=false)]
        public bool? IsRecordingEnabled { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OutOrderId")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PhoneNoA")]
        [Validation(Required=false)]
        public string PhoneNoA { get; set; }

        [NameInMap("PhoneNoB")]
        [Validation(Required=false)]
        public string PhoneNoB { get; set; }

        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RingConfig")]
        [Validation(Required=false)]
        public string RingConfig { get; set; }

    }

}
