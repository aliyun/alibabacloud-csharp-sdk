// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeSrcRdsListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSrcRdsListResponseBodyData Data { get; set; }
        public class DescribeSrcRdsListResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DescribeSrcRdsListResponseBodyDataData> Data { get; set; }
            public class DescribeSrcRdsListResponseBodyDataData : TeaModel {
                public string DbName { get; set; }
                public string Rds { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
