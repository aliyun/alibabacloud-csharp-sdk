// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetMonitorListResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetMonitorListResponseData Data { get; set; }
        public class GetMonitorListResponseData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=true)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=true)]
            public int? TotalPage { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<GetMonitorListResponseDataRecords> Records { get; set; }
            public class GetMonitorListResponseDataRecords : TeaModel {
                public string TaskId { get; set; }
                public string Status { get; set; }
                public string MonitorType { get; set; }
                public string RuleName { get; set; }
                public string AlgorithmVendor { get; set; }
                public string CreateDate { get; set; }
                public string ModifiedDate { get; set; }
                public string DeviceList { get; set; }
                public string Attributes { get; set; }
                public string RuleExpression { get; set; }
                public string NotifierType { get; set; }
                public string NotifierExtra { get; set; }
                public string Description { get; set; }
                public string Expression { get; set; }
                public string ImageMatch { get; set; }
            }
        };

    }

}
