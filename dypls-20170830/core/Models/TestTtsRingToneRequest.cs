// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class TestTtsRingToneRequest : TeaModel {
        [NameInMap("BillId")]
        [Validation(Required=false)]
        public string BillId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Tts")]
        [Validation(Required=false)]
        public string Tts { get; set; }

        [NameInMap("VoiceSpeed")]
        [Validation(Required=false)]
        public string VoiceSpeed { get; set; }

        [NameInMap("VoiceStyle")]
        [Validation(Required=false)]
        public string VoiceStyle { get; set; }

        [NameInMap("VoiceType")]
        [Validation(Required=false)]
        public string VoiceType { get; set; }

        [NameInMap("VoiceVolume")]
        [Validation(Required=false)]
        public string VoiceVolume { get; set; }

    }

}
