// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeBgpPackByIpResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("DdosbgpInfo")]
        [Validation(Required=false)]
        public DescribeBgpPackByIpResponseBodyDdosbgpInfo DdosbgpInfo { get; set; }
        public class DescribeBgpPackByIpResponseBodyDdosbgpInfo : TeaModel {
            [NameInMap("BaseThreshold")]
            [Validation(Required=false)]
            public int? BaseThreshold { get; set; }
            [NameInMap("DdosbgpInstanceId")]
            [Validation(Required=false)]
            public string DdosbgpInstanceId { get; set; }
            [NameInMap("ElasticThreshold")]
            [Validation(Required=false)]
            public int? ElasticThreshold { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
