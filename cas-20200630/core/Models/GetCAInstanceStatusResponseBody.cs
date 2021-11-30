// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCAInstanceStatusResponseBody : TeaModel {
        [NameInMap("InstanceStatusList")]
        [Validation(Required=false)]
        public List<GetCAInstanceStatusResponseBodyInstanceStatusList> InstanceStatusList { get; set; }
        public class GetCAInstanceStatusResponseBodyInstanceStatusList : TeaModel {
            [NameInMap("AfterTime")]
            [Validation(Required=false)]
            public long? AfterTime { get; set; }

            [NameInMap("BeforeTime")]
            [Validation(Required=false)]
            public long? BeforeTime { get; set; }

            [NameInMap("CertIssuedCount")]
            [Validation(Required=false)]
            public int? CertIssuedCount { get; set; }

            [NameInMap("CertTotalCount")]
            [Validation(Required=false)]
            public int? CertTotalCount { get; set; }

            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UseExpireTime")]
            [Validation(Required=false)]
            public long? UseExpireTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
