// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CloseSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i207023871669364793713</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>03f53c719015a9ad4f4f55d66cac2dac161b18e8065ca75a3220b89de389c980</para>
        /// </summary>
        [NameInMap("SessionToken")]
        [Validation(Required=false)]
        public string SessionToken { get; set; }

    }

}
