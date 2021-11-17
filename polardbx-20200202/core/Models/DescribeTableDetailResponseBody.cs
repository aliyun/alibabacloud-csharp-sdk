// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeTableDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTableDetailResponseBodyData Data { get; set; }
        public class DescribeTableDetailResponseBodyData : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeTableDetailResponseBodyDataFields> Fields { get; set; }
            public class DescribeTableDetailResponseBodyDataFields : TeaModel {
                public string Column { get; set; }
                public string DataType { get; set; }
                public string Extra { get; set; }
                public string Key { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
