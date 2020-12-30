// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllPlatformTypesResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetAllPlatformTypesResponseBodyDataList DataList { get; set; }
        public class GetAllPlatformTypesResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetAllPlatformTypesResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetAllPlatformTypesResponseBodyDataListUsageData : TeaModel {
                public int? Code { get; set; }
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
