// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataByTimeStampResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

        [NameInMap("BpsDataList")]
        [Validation(Required=false)]
        public DescribeLiveDomainBpsDataByTimeStampResponseBodyBpsDataList BpsDataList { get; set; }
        public class DescribeLiveDomainBpsDataByTimeStampResponseBodyBpsDataList : TeaModel {
            [NameInMap("BpsDataModel")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel> BpsDataModel { get; set; }
            public class DescribeLiveDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel : TeaModel {
                public string TimeStamp { get; set; }
                public string LocationName { get; set; }
                public string IspName { get; set; }
                public long? Bps { get; set; }
            }
        };

    }

}
