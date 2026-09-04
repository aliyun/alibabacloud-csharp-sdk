// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class BatchRemoveOperatingObjectFavoritesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The graph name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The object type, such as customer. This parameter has a value when type is set to mention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The digital employee name (operating object name, optional).</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The number of remaining favorited objects within the specified scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("remainingCount")]
        [Validation(Required=false)]
        public long? RemainingCount { get; set; }

        /// <summary>
        /// <para>The number of physical favorite records that are actually deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("removedCount")]
        [Validation(Required=false)]
        public long? RemovedCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para><b>The number of requested members before deduplication.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("requestedCount")]
        [Validation(Required=false)]
        public long? RequestedCount { get; set; }

        /// <summary>
        /// <para>The relationships between internal and external DingTalk users that failed to be created.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<BatchRemoveOperatingObjectFavoritesResponseBodyResults> Results { get; set; }
        public class BatchRemoveOperatingObjectFavoritesResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Indicates whether the object is favorited after the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isFavorited")]
            [Validation(Required=false)]
            public bool? IsFavorited { get; set; }

            /// <summary>
            /// <para>The aligned object ID: target ID or KR ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether the request has been processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("processed")]
            [Validation(Required=false)]
            public bool? Processed { get; set; }

        }

    }

}
