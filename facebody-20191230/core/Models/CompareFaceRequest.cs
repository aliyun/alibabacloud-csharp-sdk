// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CompareFaceRequest : TeaModel {
        /// <summary>
        /// 质量分阈值，取值范围 [0.0, 100.0],   0.0或空  表示不做质量分判断逻辑。
        /// </summary>
        [NameInMap("QualityScoreThreshold")]
        [Validation(Required=false)]
        public float? QualityScoreThreshold { get; set; }

        [NameInMap("ImageURLA")]
        [Validation(Required=false)]
        public string ImageURLA { get; set; }

        [NameInMap("ImageURLB")]
        [Validation(Required=false)]
        public string ImageURLB { get; set; }

        [NameInMap("ImageDataA")]
        [Validation(Required=false)]
        public byte[] ImageDataA { get; set; }

        [NameInMap("ImageDataB")]
        [Validation(Required=false)]
        public byte[] ImageDataB { get; set; }

    }

}
