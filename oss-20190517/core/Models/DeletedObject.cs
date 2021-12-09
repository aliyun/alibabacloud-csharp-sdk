// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class DeletedObject : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("DeleteMarker")]
        [Validation(Required=false)]
        public bool? DeleteMarker { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("DeleteMarkerVersionId")]
        [Validation(Required=false)]
        public string DeleteMarkerVersionId { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
