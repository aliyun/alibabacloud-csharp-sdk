/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class CompareImageFacesRequest : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("ImageUriA")]
        [Validation(Required=false)]
        public string ImageUriA { get; set; }

        [NameInMap("ImageUriB")]
        [Validation(Required=false)]
        public string ImageUriB { get; set; }

        [NameInMap("FaceIdA")]
        [Validation(Required=false)]
        public string FaceIdA { get; set; }

        [NameInMap("FaceIdB")]
        [Validation(Required=false)]
        public string FaceIdB { get; set; }

    }

}
