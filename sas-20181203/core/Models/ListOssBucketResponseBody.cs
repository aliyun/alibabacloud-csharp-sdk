// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketResponseBody : TeaModel {
        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOssBucketResponseBodyData> Data { get; set; }
        public class ListOssBucketResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the bucket.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// The reason why the bucket cannot be checked.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The storage class of the bucket. Valid values:
            /// 
            /// *   Standard (default)
            /// *   IA
            /// *   Archive
            /// *   ColdArchive
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// Indicates whether the bucket can be checked. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Support")]
            [Validation(Required=false)]
            public bool? Support { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
