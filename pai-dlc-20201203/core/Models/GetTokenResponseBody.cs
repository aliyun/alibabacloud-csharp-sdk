// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used for diagnostics and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-xxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sharing token of the job, which can be used to view information about the shared job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9*****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
