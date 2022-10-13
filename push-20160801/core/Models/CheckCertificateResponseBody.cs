// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckCertificateResponseBody : TeaModel {
        [NameInMap("Android")]
        [Validation(Required=false)]
        public bool? Android { get; set; }

        [NameInMap("DevelopmentCertInfo")]
        [Validation(Required=false)]
        public CheckCertificateResponseBodyDevelopmentCertInfo DevelopmentCertInfo { get; set; }
        public class CheckCertificateResponseBodyDevelopmentCertInfo : TeaModel {
            [NameInMap("ExipreTime")]
            [Validation(Required=false)]
            public long? ExipreTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("IOS")]
        [Validation(Required=false)]
        public bool? IOS { get; set; }

        [NameInMap("ProductionCertInfo")]
        [Validation(Required=false)]
        public CheckCertificateResponseBodyProductionCertInfo ProductionCertInfo { get; set; }
        public class CheckCertificateResponseBodyProductionCertInfo : TeaModel {
            [NameInMap("ExipreTime")]
            [Validation(Required=false)]
            public long? ExipreTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
