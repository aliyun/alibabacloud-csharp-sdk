// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeDrdsInstanceNetInfoForInnerResponseBody : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("NetInfos")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceNetInfoForInnerResponseBodyNetInfos NetInfos { get; set; }
        public class DescribeDrdsInstanceNetInfoForInnerResponseBodyNetInfos : TeaModel {
            [NameInMap("NetInfo")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceNetInfoForInnerResponseBodyNetInfosNetInfo> NetInfo { get; set; }
            public class DescribeDrdsInstanceNetInfoForInnerResponseBodyNetInfosNetInfo : TeaModel {
                public string IP { get; set; }
                public bool? IsForVpc { get; set; }
                public string Port { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
