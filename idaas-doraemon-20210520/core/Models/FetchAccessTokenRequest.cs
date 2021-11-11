// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class FetchAccessTokenRequest : TeaModel {
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        [NameInMap("MobileExtendParamsJson")]
        [Validation(Required=false)]
        public string MobileExtendParamsJson { get; set; }

        [NameInMap("MobileExtendParamsJsonSign")]
        [Validation(Required=false)]
        public string MobileExtendParamsJsonSign { get; set; }

        [NameInMap("ServerExtendParamsJson")]
        [Validation(Required=false)]
        public string ServerExtendParamsJson { get; set; }

        [NameInMap("XClientIp")]
        [Validation(Required=false)]
        public string XClientIp { get; set; }

    }

}
