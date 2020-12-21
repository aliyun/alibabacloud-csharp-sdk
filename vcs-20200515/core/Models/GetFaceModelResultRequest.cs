// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetFaceModelResultRequest : TeaModel {
        [NameInMap("PictureId")]
        [Validation(Required=false)]
        public string PictureId { get; set; }

        [NameInMap("PictureContent")]
        [Validation(Required=false)]
        public string PictureContent { get; set; }

        [NameInMap("PictureUrl")]
        [Validation(Required=false)]
        public string PictureUrl { get; set; }

    }

}
