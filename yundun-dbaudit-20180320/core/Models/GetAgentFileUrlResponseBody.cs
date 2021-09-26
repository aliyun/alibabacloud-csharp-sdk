// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetAgentFileUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LinuxFileUrl")]
        [Validation(Required=false)]
        public string LinuxFileUrl { get; set; }

        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("WinFileUrl")]
        [Validation(Required=false)]
        public string WinFileUrl { get; set; }

    }

}
