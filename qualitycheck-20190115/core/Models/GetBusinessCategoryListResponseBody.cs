// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetBusinessCategoryListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBusinessCategoryListResponseBodyData Data { get; set; }
        public class GetBusinessCategoryListResponseBodyData : TeaModel {
            [NameInMap("BusinessCategoryBasicInfo")]
            [Validation(Required=false)]
            public List<GetBusinessCategoryListResponseBodyDataBusinessCategoryBasicInfo> BusinessCategoryBasicInfo { get; set; }
            public class GetBusinessCategoryListResponseBodyDataBusinessCategoryBasicInfo : TeaModel {
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public int? Bid { get; set; }

                [NameInMap("BusinessName")]
                [Validation(Required=false)]
                public string BusinessName { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
