// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class UrlAsyncModerationRequest : TeaModel {
        /// <summary>
        /// <para>The type of the moderation service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters required by the moderation service. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;url&quot;: &quot;<a href="https://help.aliyun.com/">https://help.aliyun.com/</a>&quot;,
        ///         &quot;dataId&quot;: &quot;url123******&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
