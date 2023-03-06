// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceIndicesResponseBody : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceIndicesResponseBodyHeaders Headers { get; set; }
        public class ListInstanceIndicesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The total number of indexes in Cloud Hosting.
            /// </summary>
            [NameInMap("X-Managed-Count")]
            [Validation(Required=false)]
            public int? XManagedCount { get; set; }

            /// <summary>
            /// The total size of the index in Cloud Hosting. Unit: bytes.
            /// </summary>
            [NameInMap("X-Managed-StorageSize")]
            [Validation(Required=false)]
            public long? XManagedStorageSize { get; set; }

            /// <summary>
            /// The total number of indexes in the OpenStore cold phase.
            /// </summary>
            [NameInMap("X-OSS-Count")]
            [Validation(Required=false)]
            public int? XOSSCount { get; set; }

            /// <summary>
            /// The total size of the OpenStore cold stage index for this instance. Unit: bytes.
            /// </summary>
            [NameInMap("X-OSS-StorageSize")]
            [Validation(Required=false)]
            public long? XOSSStorageSize { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the index list.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceIndicesResponseBodyResult> Result { get; set; }
        public class ListInstanceIndicesResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the index list was queried.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The running status of the index. The following three statuses are supported:
            /// 
            /// *   green: healthy.
            /// *   yellow: alerts.
            /// *   red: an exception.
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// The full lifecycle status of the current index.
            /// </summary>
            [NameInMap("ilmExplain")]
            [Validation(Required=false)]
            public string IlmExplain { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("isManaged")]
            [Validation(Required=false)]
            public string IsManaged { get; set; }

            /// <summary>
            /// The managed status of the index. The following three statuses are supported:
            /// 
            /// *   following: Hosting.
            /// *   closing: The instance is being unhosted.
            /// *   closed: unmanaged.
            /// </summary>
            [NameInMap("managedStatus")]
            [Validation(Required=false)]
            public string ManagedStatus { get; set; }

            /// <summary>
            /// The name of the Elasticsearch index.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The current storage lifecycle. Value meaning:
            /// 
            /// *   warm: warm.
            /// *   cold: the cold phase.
            /// *   hot: hot phase.
            /// *   delete: deletes a stage.
            /// 
            /// >  If this parameter is empty, the current index is not managed by the lifecycle.
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// The total storage space occupied by the current index. Unit: bytes.
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

    }

}
