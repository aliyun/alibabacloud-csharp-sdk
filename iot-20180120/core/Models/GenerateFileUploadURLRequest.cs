// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GenerateFileUploadURLRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("FileSuffix")]
        [Validation(Required=true)]
        public string FileSuffix { get; set; }

        [NameInMap("BizCode")]
        [Validation(Required=true)]
        public string BizCode { get; set; }

    }

}
