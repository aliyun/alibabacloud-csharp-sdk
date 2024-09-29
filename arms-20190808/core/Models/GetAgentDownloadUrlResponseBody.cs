// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAgentDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The download URL of the ARMS agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://arms-apm-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/2.7.1.1/">http://arms-apm-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/2.7.1.1/</a></para>
        /// </summary>
        [NameInMap("ArmsAgentDownloadUrl")]
        [Validation(Required=false)]
        public string ArmsAgentDownloadUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14043452-D486-4EA1-80C9-BA73FB81****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
