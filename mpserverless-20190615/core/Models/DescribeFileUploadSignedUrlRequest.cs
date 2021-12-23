// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeFileUploadSignedUrlRequest : TeaModel {
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
