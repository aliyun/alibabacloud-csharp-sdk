// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetStatisticsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStatisticsResponseBodyData Data { get; set; }
        public class GetStatisticsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetStatisticsResponseBodyDataItems> Items { get; set; }
            public class GetStatisticsResponseBodyDataItems : TeaModel {
                public string DepartmentName { get; set; }
                public long? CloudCount { get; set; }
                public string Month { get; set; }
                public long? ClientCount { get; set; }
                public List<GetStatisticsResponseBodyDataItemsDetail> Detail { get; set; }
                public class GetStatisticsResponseBodyDataItemsDetail : TeaModel {
                    public string DepartmentName { get; set; }
                    public long? CloudCount { get; set; }
                    public string DepartmentId { get; set; }
                    public int? Month { get; set; }
                    public long? ClientCount { get; set; }
                }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
