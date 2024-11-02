// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateAScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The asynchronous task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e82b5f4-1ba9-4d20-89c8-1082ebaa****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACA19FE1-C09E-53C7-8FDA-560F49D71891</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
