// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CountActivatedOrNewRegistrationDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public CountActivatedOrNewRegistrationDeviceResponseBodyStatistics Statistics { get; set; }
        public class CountActivatedOrNewRegistrationDeviceResponseBodyStatistics : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<CountActivatedOrNewRegistrationDeviceResponseBodyStatisticsSeries> Series { get; set; }
            public class CountActivatedOrNewRegistrationDeviceResponseBodyStatisticsSeries : TeaModel {
                public string Name { get; set; }
                public List<string> Data { get; set; }
            }
        };

    }

}
