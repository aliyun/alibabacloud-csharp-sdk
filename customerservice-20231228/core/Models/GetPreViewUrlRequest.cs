// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class GetPreViewUrlRequest : TeaModel {
        [NameInMap("applyCode")]
        [Validation(Required=false)]
        public string ApplyCode { get; set; }

        [NameInMap("fileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        [NameInMap("fileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
