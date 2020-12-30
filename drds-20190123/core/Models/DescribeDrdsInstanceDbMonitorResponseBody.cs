// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceDbMonitorResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDrdsInstanceDbMonitorResponseBodyData> Data { get; set; }
        public class DescribeDrdsInstanceDbMonitorResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceDbMonitorResponseBodyDataValues> Values { get; set; }
            public class DescribeDrdsInstanceDbMonitorResponseBodyDataValues : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
