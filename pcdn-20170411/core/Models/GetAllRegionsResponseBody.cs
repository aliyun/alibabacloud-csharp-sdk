// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllRegionsResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetAllRegionsResponseBodyDataList DataList { get; set; }
        public class GetAllRegionsResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetAllRegionsResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetAllRegionsResponseBodyDataListUsageData : TeaModel {
                public string Code { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
