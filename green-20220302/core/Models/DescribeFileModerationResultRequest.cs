// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeFileModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>The type of the moderation service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters required by the moderation service. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>taskId: required. The URL of the object that you want to moderate. Make sure that the URL can be accessed over the Internet.</description></item>
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
