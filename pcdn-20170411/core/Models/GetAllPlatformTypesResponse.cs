// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllPlatformTypesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetAllPlatformTypesResponseDataList DataList { get; set; }
        public class GetAllPlatformTypesResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetAllPlatformTypesResponseDataListUsageData> UsageData { get; set; }
            public class GetAllPlatformTypesResponseDataListUsageData : TeaModel {
                public int? Code { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
