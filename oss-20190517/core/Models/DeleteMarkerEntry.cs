// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class DeleteMarkerEntry : TeaModel {
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

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

        /// <summary>
        /// The version ID of the object
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
