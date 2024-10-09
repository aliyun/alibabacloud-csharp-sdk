// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class CheckRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckRulesResponseBodyData Data { get; set; }
        public class CheckRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>t-0000e4w0u1v592zdf6s7</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>700683DE-0154-56D4-8D76-3B7A2C2C7DF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
