// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ObjectVersion : TeaModel {
        /// <summary>
        /// The entity tag
        /// </summary>
        [NameInMap("ETag")]
        [Validation(Required=false)]
        public string ETag { get; set; }

        /// <summary>
        /// Indicates whether the version is the current version
        /// </summary>
        [NameInMap("IsLatest")]
        [Validation(Required=false)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// The name of the object
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The last modified time of the object
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// The information about the bucket owner
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

        /// <summary>
        /// The size of the returned object
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// The version ID of the object
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
