// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllAppVersionsResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetAllAppVersionsResponseBodyDataList DataList { get; set; }
        public class GetAllAppVersionsResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetAllAppVersionsResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetAllAppVersionsResponseBodyDataListUsageData : TeaModel {
                public string Value { get; set; }
                public int? Code { get; set; }
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
