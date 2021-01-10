// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GenerateSysAppDownloadInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SysAppDownloadInfo")]
        [Validation(Required=false)]
        public GenerateSysAppDownloadInfoResponseBodySysAppDownloadInfo SysAppDownloadInfo { get; set; }
        public class GenerateSysAppDownloadInfoResponseBodySysAppDownloadInfo : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

    }

}
