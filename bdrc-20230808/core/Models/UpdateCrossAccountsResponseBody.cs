// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class UpdateCrossAccountsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateCrossAccountsResponseBodyData Data { get; set; }
        public class UpdateCrossAccountsResponseBodyData : TeaModel {
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
        /// <para>8724BC18-904D-5A0D-BFF4-F0554F0037E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
