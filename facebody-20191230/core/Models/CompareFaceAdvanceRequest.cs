// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceAdvanceRequest : TeaModel {
        [NameInMap("ImageDataA")]
        [Validation(Required=false)]
        public byte[] ImageDataA { get; set; }

        [NameInMap("ImageDataB")]
        [Validation(Required=false)]
        public byte[] ImageDataB { get; set; }

        [NameInMap("ImageURLA")]
        [Validation(Required=false)]
        public Stream ImageURLAObject { get; set; }

        [NameInMap("ImageURLB")]
        [Validation(Required=false)]
        public Stream ImageURLBObject { get; set; }

        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

    }

}
