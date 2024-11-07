// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VoiceModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>The type of the moderation service. Valid values: nickname_detection: user nickname</para>
        /// 
        /// <b>Example:</b>
        /// <para>nickname_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters of API requests that are sent from API Gateway to the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43988.html">ServiceParameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;taskId&quot;:&quot;xxxxx-xxxx&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
