// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class StopAppSessionRequest : TeaModel {
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
        public List<StopAppSessionRequestStopParam> StopParam { get; set; }
        public class StopAppSessionRequestStopParam : TeaModel {
            /// <summary>
            /// 目前支持的枚举值包括：
            /// - reason：停止原因。
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// key对应的取值。
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

    }

}
