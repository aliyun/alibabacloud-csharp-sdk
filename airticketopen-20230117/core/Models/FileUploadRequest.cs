// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class FileUploadRequest : TeaModel {
        [NameInMap("file_content")]
        [Validation(Required=false)]
        public string FileContent { get; set; }

        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

    }

}
