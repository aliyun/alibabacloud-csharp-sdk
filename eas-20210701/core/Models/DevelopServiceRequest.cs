// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DevelopServiceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to exit development mode. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// </summary>
        [NameInMap("Exit")]
        [Validation(Required=false)]
        public string Exit { get; set; }

    }

}
