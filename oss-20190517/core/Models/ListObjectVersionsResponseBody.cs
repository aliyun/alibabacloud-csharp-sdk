// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListObjectVersionsResponseBody : TeaModel {
        [NameInMap("CommonPrefixes")]
        [Validation(Required=false)]
        public List<CommonPrefix> CommonPrefixes { get; set; }

        [NameInMap("DeleteMarker")]
        [Validation(Required=false)]
        public List<DeleteMarkerEntry> DeleteMarkers { get; set; }

        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        [NameInMap("KeyMarker")]
        [Validation(Required=false)]
        public string KeyMarker { get; set; }

        [NameInMap("MaxKeys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NextKeyMarker")]
        [Validation(Required=false)]
        public string NextKeyMarker { get; set; }

        [NameInMap("NextVersionIdMarker")]
        [Validation(Required=false)]
        public string NextVersionIdMarker { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public List<ObjectVersion> Versions { get; set; }

        [NameInMap("VersionIdMarker")]
        [Validation(Required=false)]
        public string VersionIdMarker { get; set; }

    }

}
