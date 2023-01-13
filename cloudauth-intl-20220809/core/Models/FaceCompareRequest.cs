// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCompareRequest : TeaModel {
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

    }

}
