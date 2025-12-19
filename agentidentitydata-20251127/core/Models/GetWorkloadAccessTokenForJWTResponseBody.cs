// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetWorkloadAccessTokenForJWTResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D679769C-957B-586A-AD00-5C2064DAFA7D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyAgImFsZyI6ICJSUzI1N****</para>
        /// </summary>
        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

    }

}
