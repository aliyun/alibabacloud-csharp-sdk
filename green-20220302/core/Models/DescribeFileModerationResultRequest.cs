// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeFileModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>The service supported by the enhanced file moderation feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set required by the moderation service, in JSON character string format.</para>
        /// <list type="bullet">
        /// <item><description>taskId: Required. The URL of the object to be moderated. Make sure that the URL is accessible over the public network access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;taskId\&quot;:\&quot;vi_f_hPgx9PFIQISdlfA888hOFG-1yJq8v\&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
