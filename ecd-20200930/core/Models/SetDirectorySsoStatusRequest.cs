// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDirectorySsoStatusRequest : TeaModel {
        /// <summary>
        /// The AD directory ID.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Specifies whether to enable SSO. Valid values:
        /// 
        /// *   true: enables SSO.
        /// *   false: disables SSO.
        /// </summary>
        [NameInMap("EnableSso")]
        [Validation(Required=false)]
        public bool? EnableSso { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
