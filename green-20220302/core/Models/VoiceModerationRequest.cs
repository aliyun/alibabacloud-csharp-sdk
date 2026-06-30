// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VoiceModerationRequest : TeaModel {
        /// <summary>
        /// <para>The ServiceCode for voice moderation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audio_media_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The set of parameters that are required for the moderation service. The value must be a JSON string.</para>
        /// <para>url: Required. The URL of the object to be detected. Make sure that the URL is accessible over the Internet. dataId: Optional. The data ID of the object to be detected. For more information, see ServiceParameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;url&quot;: &quot;<a href="http://aliyundoc.com/test.flv">http://aliyundoc.com/test.flv</a>&quot;, &quot;dataId&quot;: &quot;data1234&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
