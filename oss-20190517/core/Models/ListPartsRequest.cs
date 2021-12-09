// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListPartsRequest : TeaModel {
        [NameInMap("encoding-type")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("max-parts")]
        [Validation(Required=false)]
        public long? MaxParts { get; set; }

        [NameInMap("part-number-marker")]
        [Validation(Required=false)]
        public long? PartNumberMarker { get; set; }

        [NameInMap("uploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
