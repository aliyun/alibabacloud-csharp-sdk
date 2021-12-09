// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ObjectSummary : TeaModel {
        /// <summary>
        /// The entity tag is a hash of the object.
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
        /// The last modification time of the object.
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

        /// <summary>
        /// The size in bytes of the object
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// The type of the object.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
