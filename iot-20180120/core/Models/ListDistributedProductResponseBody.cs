// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDistributedProductResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The products returned if the call is successful. For more information, see the "**Info**" section of this topic.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDistributedProductResponseBodyData Data { get; set; }
        public class ListDistributedProductResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the product.
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public ListDistributedProductResponseBodyDataInfo Info { get; set; }
            public class ListDistributedProductResponseBodyDataInfo : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<ListDistributedProductResponseBodyDataInfoItems> Items { get; set; }
                public class ListDistributedProductResponseBodyDataInfoItems : TeaModel {
                    /// <summary>
                    /// The time when the distribution task was created.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    /// <summary>
                    /// The **ProductKey** of the product.
                    /// </summary>
                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    /// <summary>
                    /// The ID of the source instance to which the product belongs.
                    /// </summary>
                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=false)]
                    public string SourceInstanceId { get; set; }

                    /// <summary>
                    /// The name of the source instance to which the product belongs.
                    /// </summary>
                    [NameInMap("SourceInstanceName")]
                    [Validation(Required=false)]
                    public string SourceInstanceName { get; set; }

                    /// <summary>
                    /// The source region to which the product belongs.
                    /// </summary>
                    [NameInMap("SourceRegion")]
                    [Validation(Required=false)]
                    public string SourceRegion { get; set; }

                    /// <summary>
                    /// The ID of the Alibaba Cloud account that is used to distribute the product. You can distribute products across regions and instances only within the same Alibaba cloud account. The value of this parameter is the same as the value of the **TargetUid** parameter.
                    /// </summary>
                    [NameInMap("SourceUid")]
                    [Validation(Required=false)]
                    public string SourceUid { get; set; }

                    /// <summary>
                    /// The name of the Alibaba Cloud account to which the product is distributed.
                    /// </summary>
                    [NameInMap("TargetAliyunId")]
                    [Validation(Required=false)]
                    public string TargetAliyunId { get; set; }

                    /// <summary>
                    /// The ID of the destination instance to which the product is distributed.
                    /// </summary>
                    [NameInMap("TargetInstanceId")]
                    [Validation(Required=false)]
                    public string TargetInstanceId { get; set; }

                    /// <summary>
                    /// The name of the destination instance to which the product is distributed.
                    /// </summary>
                    [NameInMap("TargetInstanceName")]
                    [Validation(Required=false)]
                    public string TargetInstanceName { get; set; }

                    /// <summary>
                    /// The destination region to which the product is distributed.
                    /// </summary>
                    [NameInMap("TargetRegion")]
                    [Validation(Required=false)]
                    public string TargetRegion { get; set; }

                    /// <summary>
                    /// The ID of the Alibaba Cloud account to which the product is distributed.
                    /// 
                    /// You can distribute devices across regions and instances only within the same Alibaba cloud account. The value of this parameter is the same as the value of the **TargetUid** parameter.
                    /// </summary>
                    [NameInMap("TargetUid")]
                    [Validation(Required=false)]
                    public string TargetUid { get; set; }

                }

            }

            /// <summary>
            /// The total number of returned products.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
