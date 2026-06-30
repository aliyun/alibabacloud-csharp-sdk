// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class UrlAsyncModerationRequest : TeaModel {
        /// <summary>
        /// <para>Service name: URL threat detection</para>
        /// 
        /// <b>Example:</b>
        /// <para>url_detection_pro</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set for the content moderation object. This parameter is a JSON string. For more information, see the description of ServiceParameters.</para>
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
