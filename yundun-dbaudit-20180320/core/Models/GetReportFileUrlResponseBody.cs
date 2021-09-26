// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetReportFileUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerData")]
        [Validation(Required=false)]
        public GetReportFileUrlResponseBodyServerData ServerData { get; set; }
        public class GetReportFileUrlResponseBodyServerData : TeaModel {
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }
        };

    }

}
