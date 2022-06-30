// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAreaResponseBody : TeaModel {
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAreaResponseBodyAreas> Areas { get; set; }
        public class DescribeDDosEventAreaResponseBodyAreas : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
