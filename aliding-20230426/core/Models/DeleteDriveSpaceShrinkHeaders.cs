// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class DeleteDriveSpaceShrinkHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountContext")]
        [Validation(Required=false)]
        public string AccountContextShrink { get; set; }

    }

}
