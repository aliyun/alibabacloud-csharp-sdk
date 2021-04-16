// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class GetCdrsMonitorListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCdrsMonitorListResponseBodyData Data { get; set; }
        public class GetCdrsMonitorListResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetCdrsMonitorListResponseBodyDataRecords> Records { get; set; }
            public class GetCdrsMonitorListResponseBodyDataRecords : TeaModel {
                public string Status { get; set; }
                public string RuleExpression { get; set; }
                public string ImageMatch { get; set; }
                public string MonitorType { get; set; }
                public string CreateDate { get; set; }
                public string RuleName { get; set; }
                public string NotifierType { get; set; }
                public string Description { get; set; }
                public string Expression { get; set; }
                public string NotifierExtra { get; set; }
                public string Attributes { get; set; }
                public string DeviceList { get; set; }
                public string TaskId { get; set; }
                public string ModifiedDate { get; set; }
                public string AlgorithmVendor { get; set; }
            }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
