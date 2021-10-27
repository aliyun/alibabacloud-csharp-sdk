// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceVerifyRequest : TeaModel {
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        [NameInMap("PictureReturnType")]
        [Validation(Required=false)]
        public string PictureReturnType { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
