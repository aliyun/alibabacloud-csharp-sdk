// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class CreateSessionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>44553E9A-******-37ADC33FE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>se-weg******iqwcw</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
