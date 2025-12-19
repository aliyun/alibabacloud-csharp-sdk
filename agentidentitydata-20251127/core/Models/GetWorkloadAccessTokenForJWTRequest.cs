// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetWorkloadAccessTokenForJWTRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eyAgImFsZyI6ICJSUzI1NiIsI*******</para>
        /// </summary>
        [NameInMap("UserToken")]
        [Validation(Required=false)]
        public string UserToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-workload-identity</para>
        /// </summary>
        [NameInMap("WorkloadIdentityName")]
        [Validation(Required=false)]
        public string WorkloadIdentityName { get; set; }

    }

}
