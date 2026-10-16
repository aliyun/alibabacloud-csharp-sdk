// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetUserPasswordResponseBody : TeaModel {
        /// <summary>
        /// <para>The system-generated random password returned when GenerateRandomPassword is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xk9mP2vL5nQ8</para>
        /// </summary>
        [NameInMap("RandomPassword")]
        [Validation(Required=false)]
        public string RandomPassword { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
