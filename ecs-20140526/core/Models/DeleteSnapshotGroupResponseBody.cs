// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteSnapshotGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the delete operation.</para>
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
                /// <para>The error code. This parameter is empty when the operation is successful.</para>
                /// <para>For information about error codes and error messages, visit the <a href="https://error-center.aliyun.com/status/product/Ecs">API error center</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message. This parameter is empty when the operation is successful.</para>
                /// <para>For information about error codes and error messages, visit the <a href="https://error-center.aliyun.com/status/product/Ecs">API error center</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testErrorMsg</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation was successful. If the operation was successful, a value of Success is returned. If the operation failed, an error code and an error message are returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("OperationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                /// <summary>
                /// <para>Details about the resources.</para>
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
                        /// <para>The name of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SnapshotId</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The ID of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-j6c9lpuyxo2uxxnx****</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EDE885A-FDC1-4FAE-BC44-6EACAEA6CC6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
