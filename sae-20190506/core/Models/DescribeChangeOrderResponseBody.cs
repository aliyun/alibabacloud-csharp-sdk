// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeChangeOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeChangeOrderResponseBodyData Data { get; set; }
        public class DescribeChangeOrderResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }
            [NameInMap("BatchCount")]
            [Validation(Required=false)]
            public int? BatchCount { get; set; }
            [NameInMap("BatchType")]
            [Validation(Required=false)]
            public string BatchType { get; set; }
            [NameInMap("BatchWaitTime")]
            [Validation(Required=false)]
            public int? BatchWaitTime { get; set; }
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }
            [NameInMap("CoType")]
            [Validation(Required=false)]
            public string CoType { get; set; }
            [NameInMap("CoTypeCode")]
            [Validation(Required=false)]
            public string CoTypeCode { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("CurrentPipelineId")]
            [Validation(Required=false)]
            public string CurrentPipelineId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("Pipelines")]
            [Validation(Required=false)]
            public List<DescribeChangeOrderResponseBodyDataPipelines> Pipelines { get; set; }
            public class DescribeChangeOrderResponseBodyDataPipelines : TeaModel {
                public int? BatchType { get; set; }
                public int? ParallelCount { get; set; }
                public string PipelineId { get; set; }
                public string PipelineName { get; set; }
                public long? StartTime { get; set; }
                public int? Status { get; set; }
                public long? UpdateTime { get; set; }
            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public int? SubStatus { get; set; }
            [NameInMap("SupportRollback")]
            [Validation(Required=false)]
            public bool? SupportRollback { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
