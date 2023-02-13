// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteSnapshotGroupResponseBody : TeaModel {
        /// <summary>
        /// Details about the delete operation.
        /// </summary>
        [NameInMap("OperationProgressSet")]
        [Validation(Required=false)]
        public DeleteSnapshotGroupResponseBodyOperationProgressSet OperationProgressSet { get; set; }
        public class DeleteSnapshotGroupResponseBodyOperationProgressSet : TeaModel {
            [NameInMap("OperationProgress")]
            [Validation(Required=false)]
            public List<DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgress> OperationProgress { get; set; }
            public class DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgress : TeaModel {
                /// <summary>
                /// The error code. This parameter is empty when the operation was successful.
                /// 
                /// For information about error codes and error messages, visit the [API error center](https://error-center.alibabacloud.com/status/product/Ecs).
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message. This parameter is empty when the operation was successful.
                /// 
                /// For information about error codes and error messages, visit the [API error center](https://error-center.alibabacloud.com/status/product/Ecs).
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// Indicates whether the operation was successful. If the operation was successful, a value of Success is returned. If the operation failed, an error code and an error message are returned.
                /// </summary>
                [NameInMap("OperationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                /// <summary>
                /// Details about the resources.
                /// </summary>
                [NameInMap("RelatedItemSet")]
                [Validation(Required=false)]
                public DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class DeleteSnapshotGroupResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
                        /// <summary>
                        /// The name of the resource.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The ID of the resource.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
