// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetWebTerminalRequest : TeaModel {
        [NameInMap("IsShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// Pod UID。
        /// </summary>
        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

    }

}
