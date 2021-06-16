// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByTimeStampResponseBody : TeaModel {
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("BpsDataList")]
        [Validation(Required=false)]
        public DescribeDomainBpsDataByTimeStampResponseBodyBpsDataList BpsDataList { get; set; }
        public class DescribeDomainBpsDataByTimeStampResponseBodyBpsDataList : TeaModel {
            [NameInMap("BpsDataModel")]
            [Validation(Required=false)]
            public List<DescribeDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel> BpsDataModel { get; set; }
            public class DescribeDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel : TeaModel {
                public string LocationName { get; set; }
                public string TimeStamp { get; set; }
                public string IspName { get; set; }
                public long? Bps { get; set; }
            }
        };

    }

}
