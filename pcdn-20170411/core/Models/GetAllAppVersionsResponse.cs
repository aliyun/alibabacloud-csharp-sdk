// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllAppVersionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetAllAppVersionsResponseDataList DataList { get; set; }
        public class GetAllAppVersionsResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetAllAppVersionsResponseDataListUsageData> UsageData { get; set; }
            public class GetAllAppVersionsResponseDataListUsageData : TeaModel {
                public int? Code { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
