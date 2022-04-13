// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteSnapshotGroupResponseBody : TeaModel {
        [NameInMap("OperationProgressSet")]
        [Validation(Required=false)]
        public DeleteSnapshotGroupResponseBodyOperationProgressSet OperationProgressSet { get; set; }
        public class DeleteSnapshotGroupResponseBodyOperationProgressSet : TeaModel {
            [NameInMap("OperationProgress")]
            [Validation(Required=false)]
            public List<DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgress> OperationProgress { get; set; }
            public class DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgress : TeaModel {
                public string ErrorCode { get; set; }
                public string ErrorMsg { get; set; }
                public string OperationStatus { get; set; }
                public DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
