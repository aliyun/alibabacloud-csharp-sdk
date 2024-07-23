// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResetDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the rollback operation.</para>
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
                /// <para>The error code that is returned if the request failed. This parameter is empty if the request is successful.</para>
                /// <para>For information about error codes and error messages, see <a href="https://error-center.alibabacloud.com/status/product/Ecs">Service error codes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message that is returned if the request failed. This parameter is empty if the request is successful.</para>
                /// <para>For information about error codes and error messages, see <a href="https://error-center.alibabacloud.com/status/product/Ecs">Service error codes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testErrorMsg</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>Indicates whether the request is successful. If the request is successful, Success is returned. If the request failed, an error code and an error message are returned.</para>
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
                public ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
                        /// <summary>
                        /// <para>The resource name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SnapshotId</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The resource ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-j6cdofbycydvg7ey****</para>
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
        /// <para>3D66C85C-AA97-4A00-B0ED-2D9A80FE782C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
