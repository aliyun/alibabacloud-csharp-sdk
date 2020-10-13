// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetClientsRatioResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetClientsRatioResponseDataList DataList { get; set; }
        public class GetClientsRatioResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetClientsRatioResponseDataListUsageData> UsageData { get; set; }
            public class GetClientsRatioResponseDataListUsageData : TeaModel {
                public string Name { get; set; }
                public string Rate { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
