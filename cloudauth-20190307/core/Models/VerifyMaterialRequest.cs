// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyMaterialRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=true)]
        public string BizId { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=true)]
        public string BizType { get; set; }

        [NameInMap("FaceImageUrl")]
        [Validation(Required=true)]
        public string FaceImageUrl { get; set; }

        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        [NameInMap("IdCardNumber")]
        [Validation(Required=true)]
        public string IdCardNumber { get; set; }

        [NameInMap("Name")]
        [Validation(Required=true)]
        public string Name { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
