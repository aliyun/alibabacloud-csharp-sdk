// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class GetCdrsMonitorListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCdrsMonitorListResponseBodyData Data { get; set; }
        public class GetCdrsMonitorListResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetCdrsMonitorListResponseBodyDataRecords> Records { get; set; }
            public class GetCdrsMonitorListResponseBodyDataRecords : TeaModel {
                [NameInMap("AlgorithmVendor")]
                [Validation(Required=false)]
                public string AlgorithmVendor { get; set; }

                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DeviceList")]
                [Validation(Required=false)]
                public string DeviceList { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("ImageMatch")]
                [Validation(Required=false)]
                public string ImageMatch { get; set; }

                [NameInMap("ModifiedDate")]
                [Validation(Required=false)]
                public string ModifiedDate { get; set; }

                [NameInMap("MonitorType")]
                [Validation(Required=false)]
                public string MonitorType { get; set; }

                [NameInMap("NotifierExtra")]
                [Validation(Required=false)]
                public string NotifierExtra { get; set; }

                [NameInMap("NotifierType")]
                [Validation(Required=false)]
                public string NotifierType { get; set; }

                [NameInMap("RuleExpression")]
                [Validation(Required=false)]
                public string RuleExpression { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
