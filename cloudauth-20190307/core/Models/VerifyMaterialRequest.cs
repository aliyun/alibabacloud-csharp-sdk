/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyMaterialRequest : TeaModel {
        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        [NameInMap("FaceImageUrl")]
        [Validation(Required=false)]
        public string FaceImageUrl { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
