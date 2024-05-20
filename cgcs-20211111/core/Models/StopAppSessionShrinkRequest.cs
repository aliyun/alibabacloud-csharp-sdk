// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class StopAppSessionShrinkRequest : TeaModel {
        [NameInMap("CustomSessionId")]
        [Validation(Required=false)]
        public string CustomSessionId { get; set; }

        [NameInMap("PlatformSessionId")]
        [Validation(Required=false)]
        public string PlatformSessionId { get; set; }

        /// <summary>
        /// 停止容器参数。此参数将透传到Agent。
        /// </summary>
        [NameInMap("StopParam")]
        [Validation(Required=false)]
        public string StopParamShrink { get; set; }

    }

}
