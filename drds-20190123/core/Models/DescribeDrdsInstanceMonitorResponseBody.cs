// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceMonitorResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDrdsInstanceMonitorResponseBodyData> Data { get; set; }
        public class DescribeDrdsInstanceMonitorResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceMonitorResponseBodyDataValues> Values { get; set; }
            public class DescribeDrdsInstanceMonitorResponseBodyDataValues : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
