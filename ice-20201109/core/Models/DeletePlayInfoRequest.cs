// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeletePlayInfoRequest : TeaModel {
        [NameInMap("DeletePhysicalFiles")]
        [Validation(Required=false)]
        public bool? DeletePhysicalFiles { get; set; }

        [NameInMap("FileURLs")]
        [Validation(Required=false)]
        public string FileURLs { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}
