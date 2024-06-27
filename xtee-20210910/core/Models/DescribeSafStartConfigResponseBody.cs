// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafStartConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSafStartConfigResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSafStartConfigResponseBodyResultObject : TeaModel {
            [NameInMap("deviceTypes")]
            [Validation(Required=false)]
            public List<string> DeviceTypes { get; set; }

            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public List<string> EventCodes { get; set; }

            [NameInMap("languages")]
            [Validation(Required=false)]
            public List<string> Languages { get; set; }

            [NameInMap("serverRegions")]
            [Validation(Required=false)]
            public List<string> ServerRegions { get; set; }

        }

    }

}
