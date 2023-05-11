// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class AddFaceUserPictureRequest : TeaModel {
        [NameInMap("FacePicUrl")]
        [Validation(Required=false)]
        public string FacePicUrl { get; set; }

        [NameInMap("IsolationId")]
        [Validation(Required=false)]
        public string IsolationId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
