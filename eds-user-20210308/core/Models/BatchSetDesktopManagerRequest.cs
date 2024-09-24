// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class BatchSetDesktopManagerRequest : TeaModel {
        [NameInMap("IsDesktopManager")]
        [Validation(Required=false)]
        public string IsDesktopManager { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
