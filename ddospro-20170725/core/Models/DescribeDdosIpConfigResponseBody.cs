// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeDdosIpConfigResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeDdosIpConfigResponseBodyDataList> DataList { get; set; }
        public class DescribeDdosIpConfigResponseBodyDataList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("CleanStatus")]
            [Validation(Required=false)]
            public int? CleanStatus { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("ConfigDomainCount")]
            [Validation(Required=false)]
            public int? ConfigDomainCount { get; set; }

            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            [NameInMap("ElasticBandwidth")]
            [Validation(Required=false)]
            public int? ElasticBandwidth { get; set; }

            [NameInMap("LbId")]
            [Validation(Required=false)]
            public string LbId { get; set; }

            [NameInMap("ConfigPortCount")]
            [Validation(Required=false)]
            public int? ConfigPortCount { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("TotalDefenseCount")]
            [Validation(Required=false)]
            public int? TotalDefenseCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
