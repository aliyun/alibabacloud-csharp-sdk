// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ThirdImmediateMsgPushResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>500000000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>服务器内部异常</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public ThirdImmediateMsgPushResponseBodyModel Model { get; set; }
        public class ThirdImmediateMsgPushResponseBodyModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2DF6FEFE-3301-16DD-ABCC-968A9524920B</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
