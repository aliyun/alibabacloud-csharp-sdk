// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeTaskAttributeResponseBody : TeaModel {
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        [NameInMap("OperationProgressSet")]
        [Validation(Required=false)]
        public DescribeTaskAttributeResponseBodyOperationProgressSet OperationProgressSet { get; set; }
        public class DescribeTaskAttributeResponseBodyOperationProgressSet : TeaModel {
            [NameInMap("OperationProgress")]
            [Validation(Required=false)]
            public List<DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgress> OperationProgress { get; set; }
            public class DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgress : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("OperationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                [NameInMap("RelatedItemSet")]
                [Validation(Required=false)]
                public DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class DescribeTaskAttributeResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        [NameInMap("SupportCancel")]
        [Validation(Required=false)]
        public string SupportCancel { get; set; }

        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskProcess")]
        [Validation(Required=false)]
        public string TaskProcess { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
