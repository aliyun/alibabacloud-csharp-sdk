// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAllIspResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetAllIspResponseDataList DataList { get; set; }
        public class GetAllIspResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetAllIspResponseDataListUsageData> UsageData { get; set; }
            public class GetAllIspResponseDataListUsageData : TeaModel {
                public string NameCn { get; set; }
                public string NameEn { get; set; }
                public string ResourceId { get; set; }
            }
        };

    }

}
