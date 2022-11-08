// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class DownloadLabelFileResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DownloadLabelFileResponseBodyData Data { get; set; }
        public class DownloadLabelFileResponseBodyData : TeaModel {
            [NameInMap("OssHttpUrl")]
            [Validation(Required=false)]
            public string OssHttpUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
