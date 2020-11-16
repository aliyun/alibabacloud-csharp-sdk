// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataByTimeStampResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("TimeStamp")]
        [Validation(Required=true)]
        public string TimeStamp { get; set; }

        [NameInMap("BpsDataList")]
        [Validation(Required=true)]
        public DescribeLiveDomainBpsDataByTimeStampResponseBpsDataList BpsDataList { get; set; }
        public class DescribeLiveDomainBpsDataByTimeStampResponseBpsDataList : TeaModel {
            [NameInMap("BpsDataModel")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainBpsDataByTimeStampResponseBpsDataListBpsDataModel> BpsDataModel { get; set; }
            public class DescribeLiveDomainBpsDataByTimeStampResponseBpsDataListBpsDataModel : TeaModel {
                public string TimeStamp { get; set; }
                public string LocationName { get; set; }
                public string IspName { get; set; }
                public long Bps { get; set; }
            }
        };

    }

}
