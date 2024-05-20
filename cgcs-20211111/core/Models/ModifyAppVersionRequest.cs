// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class ModifyAppVersionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppVersionId")]
        [Validation(Required=false)]
        public string AppVersionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppVersionName")]
        [Validation(Required=false)]
        public string AppVersionName { get; set; }

    }

}
