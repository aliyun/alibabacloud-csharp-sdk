// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ImageBlindPicWatermarkRequest : TeaModel {
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("LogoURL")]
        [Validation(Required=false)]
        public string LogoURL { get; set; }

        [NameInMap("OriginImageURL")]
        [Validation(Required=false)]
        public string OriginImageURL { get; set; }

        [NameInMap("OutputFileType")]
        [Validation(Required=false)]
        public string OutputFileType { get; set; }

        [NameInMap("QualityFactor")]
        [Validation(Required=false)]
        public int? QualityFactor { get; set; }

        [NameInMap("WatermarkImageURL")]
        [Validation(Required=false)]
        public string WatermarkImageURL { get; set; }

    }

}
