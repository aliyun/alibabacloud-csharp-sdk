// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class AddFaceUserRequest : TeaModel {
        [NameInMap("CustomUserId")]
        [Validation(Required=false)]
        public string CustomUserId { get; set; }

        [NameInMap("FacePicUrl")]
        [Validation(Required=false)]
        public string FacePicUrl { get; set; }

        [NameInMap("IsolationId")]
        [Validation(Required=false)]
        public string IsolationId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

    }

}
