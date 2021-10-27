// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDBResponseBodyData Data { get; set; }
        public class DescribeDrdsDBResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public string DbInstType { get; set; }
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }
            [NameInMap("InstRole")]
            [Validation(Required=false)]
            public string InstRole { get; set; }
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
