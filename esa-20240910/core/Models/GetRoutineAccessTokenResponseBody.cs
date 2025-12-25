// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EB775B32-1148-1963-9ADD-74CC90C16459</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyb3V0aW5lX2lkIjoidHktbWV0YXEtdGVzdC4xNzEzMTU1ODk3ODg1Njg2IiwiZXhwIjoxNzY0OTQ0NTU3fQ.g3gFr-6GQR8vcg6b_vy1qBZ1LDYOiDP-Sih0wtu3d64</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
