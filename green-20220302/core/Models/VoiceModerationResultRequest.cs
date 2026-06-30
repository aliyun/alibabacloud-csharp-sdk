// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VoiceModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>The moderation service type. Supported values include <c>nickname_detection</c> for user nickname moderation. Support for more types is planned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nickname_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>Parameters that the gateway sends to the backend service.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/43988.html">ServiceParameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>暂无</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
