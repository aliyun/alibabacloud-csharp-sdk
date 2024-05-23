// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeDrdsDBIpWhiteListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDBIpWhiteListResponseBodyData Data { get; set; }
        public class DescribeDrdsDBIpWhiteListResponseBodyData : TeaModel {
            [NameInMap("IpWhiteList")]
            [Validation(Required=false)]
            public DescribeDrdsDBIpWhiteListResponseBodyDataIpWhiteList IpWhiteList { get; set; }
            public class DescribeDrdsDBIpWhiteListResponseBodyDataIpWhiteList : TeaModel {
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public List<string> Ip { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
