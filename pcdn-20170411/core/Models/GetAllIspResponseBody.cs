// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllIspResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetAllIspResponseBodyDataList DataList { get; set; }
        public class GetAllIspResponseBodyDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<GetAllIspResponseBodyDataListUsageData> UsageData { get; set; }
            public class GetAllIspResponseBodyDataListUsageData : TeaModel {
                public string NameEn { get; set; }
                public string NameCn { get; set; }
                public string ResourceId { get; set; }
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
