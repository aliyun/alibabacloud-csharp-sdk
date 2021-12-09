// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListObjectVersionsResponseBody : TeaModel {
        /// <summary>
        /// Objects whose names contain the same string that ranges from the prefix to the next occurrence of the delimiter are grouped as a single result element
        /// </summary>
        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<CommonPrefix> CommonPrefixes { get; set; }

        /// <summary>
        /// The container that stores delete markers
        /// </summary>
        [NameInMap("DeleteMarker")]
        [Validation(Required=false)]
        public List<DeleteMarkerEntry> DeleteMarkers { get; set; }

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
        /// Indicates the object from which the operation starts
        /// </summary>
        [NameInMap("KeyMarker")]
        [Validation(Required=false)]
        public string KeyMarker { get; set; }

        /// <summary>
        /// The maximum number of returned objects in the response
        /// </summary>
        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        /// <summary>
        /// The bucket name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NextKeyMarker")]
        [Validation(Required=false)]
        public string NextKeyMarker { get; set; }

        [NameInMap("NextVersionIdMarker")]
        [Validation(Required=false)]
        public string NextVersionIdMarker { get; set; }

        /// <summary>
        /// The prefix that the names of returned objects must contain
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The container that stores the versions of objects except for delete markers
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public List<ObjectVersion> Versions { get; set; }

        /// <summary>
        /// This parameter is returned with KeyMarker together to indicate the version from which the operation starts
        /// </summary>
        [NameInMap("VersionIdMarker")]
        [Validation(Required=false)]
        public string VersionIdMarker { get; set; }

    }

}
