// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class CertificateQualityResponseBody : TeaModel {
        [NameInMap("ContainSeal")]
        [Validation(Required=false)]
        public string ContainSeal { get; set; }

        [NameInMap("ContainWatermark")]
        [Validation(Required=false)]
        public string ContainWatermark { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Copy")]
        [Validation(Required=false)]
        public string Copy { get; set; }

        [NameInMap("Complete")]
        [Validation(Required=false)]
        public string Complete { get; set; }

        [NameInMap("NationalEmblem")]
        [Validation(Required=false)]
        public string NationalEmblem { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("Reflection")]
        [Validation(Required=false)]
        public string Reflection { get; set; }

        [NameInMap("Electronic")]
        [Validation(Required=false)]
        public string Electronic { get; set; }

        [NameInMap("ContainFront")]
        [Validation(Required=false)]
        public string ContainFront { get; set; }

        [NameInMap("TextClarity")]
        [Validation(Required=false)]
        public string TextClarity { get; set; }

    }

}
