// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class DownloadDatasetResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DownloadDatasetResponseBodyData Data { get; set; }
        public class DownloadDatasetResponseBodyData : TeaModel {
            [NameInMap("OssHttpUrl")]
            [Validation(Required=false)]
            public string OssHttpUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
