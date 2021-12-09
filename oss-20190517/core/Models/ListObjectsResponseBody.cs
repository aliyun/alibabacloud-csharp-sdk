// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListObjectsResponseBody : TeaModel {
        /// <summary>
        /// Objects whose names contain the same string that ranges from the prefix to the next occurrence of the delimiter are grouped as a single result element
        /// </summary>
        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<CommonPrefix> CommonPrefixes { get; set; }

        /// <summary>
        /// The container that stores the returned object metadata
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<ObjectSummary> Contents { get; set; }

        /// <summary>
        /// The character used to group objects by name
        /// </summary>
        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        /// <summary>
        /// Indicates whether the returned results are truncated
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The name of the object from which the list operation begins
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The maximum number of returned objects in the response
        /// </summary>
        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public int? MaxKeys { get; set; }

        /// <summary>
        /// The bucket name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        /// <summary>
        /// The prefix that the names of returned objects contain
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}
