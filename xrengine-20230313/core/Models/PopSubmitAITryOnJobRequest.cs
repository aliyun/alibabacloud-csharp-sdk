// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class PopSubmitAITryOnJobRequest : TeaModel {
        [NameInMap("BottomsId")]
        [Validation(Required=false)]
        public string BottomsId { get; set; }

        [NameInMap("ClothingType")]
        [Validation(Required=false)]
        public string ClothingType { get; set; }

        [NameInMap("GeneratePictureNum")]
        [Validation(Required=false)]
        public int? GeneratePictureNum { get; set; }

        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("ShoeType")]
        [Validation(Required=false)]
        public string ShoeType { get; set; }

        [NameInMap("SuitId")]
        [Validation(Required=false)]
        public string SuitId { get; set; }

        [NameInMap("TopsId")]
        [Validation(Required=false)]
        public string TopsId { get; set; }

    }

}
