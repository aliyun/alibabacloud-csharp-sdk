// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllRegionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetAllRegionsResponseDataList DataList { get; set; }
        public class GetAllRegionsResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetAllRegionsResponseDataListUsageData> UsageData { get; set; }
            public class GetAllRegionsResponseDataListUsageData : TeaModel {
                public string Code { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
