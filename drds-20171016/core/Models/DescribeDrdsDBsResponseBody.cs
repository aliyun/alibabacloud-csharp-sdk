// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeDrdsDBsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDBsResponseBodyData Data { get; set; }
        public class DescribeDrdsDBsResponseBodyData : TeaModel {
            [NameInMap("Db")]
            [Validation(Required=false)]
            public List<DescribeDrdsDBsResponseBodyDataDb> Db { get; set; }
            public class DescribeDrdsDBsResponseBodyDataDb : TeaModel {
                public string CreateTime { get; set; }
                public string DbName { get; set; }
                public string Mode { get; set; }
                public string Msg { get; set; }
                public int? Status { get; set; }
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
