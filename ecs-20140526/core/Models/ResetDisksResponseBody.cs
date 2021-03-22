// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResetDisksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OperationProgressSet")]
        [Validation(Required=false)]
        public ResetDisksResponseBodyOperationProgressSet OperationProgressSet { get; set; }
        public class ResetDisksResponseBodyOperationProgressSet : TeaModel {
            [NameInMap("OperationProgress")]
            [Validation(Required=false)]
            public List<ResetDisksResponseBodyOperationProgressSetOperationProgress> OperationProgress { get; set; }
            public class ResetDisksResponseBodyOperationProgressSetOperationProgress : TeaModel {
                public string ErrorCode { get; set; }
                public string ErrorMsg { get; set; }
                public ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public string OperationStatus { get; set; }
            }
        };

    }

}
