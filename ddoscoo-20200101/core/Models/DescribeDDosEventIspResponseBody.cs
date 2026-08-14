// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventIspResponseBody : TeaModel {
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public List<DescribeDDosEventIspResponseBodyIsps> Isps { get; set; }
        public class DescribeDDosEventIspResponseBodyIsps : TeaModel {
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
