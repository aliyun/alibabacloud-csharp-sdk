// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class UploadNotaryDataRequest : TeaModel {
        [NameInMap("BizOrderNo")]
        [Validation(Required=false)]
        public string BizOrderNo { get; set; }

        [NameInMap("NotaryType")]
        [Validation(Required=false)]
        public int? NotaryType { get; set; }

        [NameInMap("UploadContext")]
        [Validation(Required=false)]
        public string UploadContext { get; set; }

    }

}
