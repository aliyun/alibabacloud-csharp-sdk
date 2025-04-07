// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieoauth2_1_0.Models
{
    public class OAuth2TokenEndpointRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rf3mi4JOU-xRIX2zEuRLHi-U9mPnvISeSphbwiBHJ5mEKZtG-xJsbBWrq8RmhQEPRYh0JOd3DaS_VZ90soD_YrsT4OBtgD06DmdIKL2_5KFfI6p_SjXX2-UMJuGfXDkB</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>authorization_code</para>
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx.xxx.com/xxx">https://xxx.xxx.com/xxx</a></para>
        /// </summary>
        [NameInMap("RedirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zsEcmaUeb8-NZW4IIUDD7qdgBNflrj6fH8BXJYbW9iXihZTgvbcr1_utC9p5HJLn_lXVwhfivBTgUQZBCGvGl5lxqaxFhmFtt-OrBduFQKL9x8p2lpEMKlxuKHZZZJ3A</para>
        /// </summary>
        [NameInMap("RefreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

    }

}
