// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResetDisksResponseBody : TeaModel {
        /// <summary>
        /// The information about the rollback operations on one or more disks.
        /// </summary>
        [NameInMap("OperationProgressSet")]
        [Validation(Required=false)]
        public ResetDisksResponseBodyOperationProgressSet OperationProgressSet { get; set; }
        public class ResetDisksResponseBodyOperationProgressSet : TeaModel {
            [NameInMap("OperationProgress")]
            [Validation(Required=false)]
            public List<ResetDisksResponseBodyOperationProgressSetOperationProgress> OperationProgress { get; set; }
            public class ResetDisksResponseBodyOperationProgressSetOperationProgress : TeaModel {
                /// <summary>
                /// The error code that is returned if the request failed. This parameter is empty if the operation is successful.
                /// 
                /// For information about error codes and error messages, see [Service error codes](https://error-center.alibabacloud.com/status/product/Ecs).
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error message that is returned if the request failed. This parameter is empty if the operation is successful.
                /// 
                /// For information about error codes and error messages, see [Service error codes](https://error-center.alibabacloud.com/status/product/Ecs).
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// Indicates whether the operation is successful. If the operation is successful, Success is returned. If the operation failed, an error code and an error message are returned.
                /// </summary>
                [NameInMap("OperationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                /// <summary>
                /// The information about the resources.
                /// </summary>
                [NameInMap("RelatedItemSet")]
                [Validation(Required=false)]
                public ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
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
