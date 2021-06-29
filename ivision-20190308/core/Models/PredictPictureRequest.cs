// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class PredictPictureRequest : TeaModel {
        [NameInMap("AlgorithmCode")]
        [Validation(Required=false)]
        public string AlgorithmCode { get; set; }

        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("ResourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

        [NameInMap("CustomerData")]
        [Validation(Required=false)]
        public string CustomerData { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
