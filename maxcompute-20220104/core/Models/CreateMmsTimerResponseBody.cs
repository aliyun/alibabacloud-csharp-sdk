// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsTimerResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateMmsTimerResponseBodyData Data { get; set; }
        public class CreateMmsTimerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>timer id</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("timerId")]
            [Validation(Required=false)]
            public long? TimerId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0be3e0b716671885050924814e3623</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
