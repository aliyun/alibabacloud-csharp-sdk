// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteBackupClientResourceShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of HBR clients. You can specify a maximum of 100 client IDs.
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIdsShrink { get; set; }

    }

}
