// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class UploadCommodityFileRequest : TeaModel {
        [NameInMap("FileContentType")]
        [Validation(Required=false)]
        public string FileContentType { get; set; }

        [NameInMap("FileResource")]
        [Validation(Required=false)]
        public string FileResource { get; set; }

        [NameInMap("FileResourceType")]
        [Validation(Required=false)]
        public string FileResourceType { get; set; }

    }

}
