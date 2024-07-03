// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListObjectsResponseBody : TeaModel {
        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// If the delimiter parameter is specified in the request, the response contains CommonPrefixes. Objects whose names contain the same string from the prefix to the next occurrence of the delimiter are grouped as a single result element in CommonPrefixes.
        /// </summary>
        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<string> CommonPrefixes { get; set; }

        /// <summary>
        /// The list of object metadata.
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<ListObjectsResponseBodyContents> Contents { get; set; }
        public class ListObjectsResponseBodyContents : TeaModel {
            /// <summary>
            /// The entity tag (ETag). When an object is created, an ETag is created to identify the content of the object.
            /// 
            /// *   For an object that is created by calling the PutObject operation, the ETag value of the object is the MD5 hash of the object content.
            /// *   For an object that is not created by calling the PutObject operation, the ETag value of the object is the UUID of the object content.
            /// *   The ETag of an object can be used to check whether the object content is modified. However, we recommend that you use the MD5 hash of an object rather than the ETag value of the object to verify data integrity.
            /// </summary>
            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }

            /// <summary>
            /// The name of the object.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The time when the object was last modified.
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// The size of the returned object. Unit: bytes.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// The token used in this list operation.
        /// </summary>
        [NameInMap("ContinuationToken")]
        [Validation(Required=false)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// The character used to group objects by name.
        /// </summary>
        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        /// <summary>
        /// The encoding type of the object names in the response.
        /// </summary>
        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        /// <summary>
        /// Indicates whether the listed objects are truncated. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The number of keys returned for this request.
        /// </summary>
        [NameInMap("KeyCount")]
        [Validation(Required=false)]
        public long? KeyCount { get; set; }

        /// <summary>
        /// The position from which the list operation starts.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The maximum number of objects returned.
        /// </summary>
        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        /// <summary>
        /// The token used in the next list operation.
        /// </summary>
        [NameInMap("NextContinuationToken")]
        [Validation(Required=false)]
        public string NextContinuationToken { get; set; }

        /// <summary>
        /// The position from which the next list operation starts.
        /// </summary>
        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        /// <summary>
        /// The prefix contained in the names of returned objects.
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
