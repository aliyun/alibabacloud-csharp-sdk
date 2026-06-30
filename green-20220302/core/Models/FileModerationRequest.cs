// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class FileModerationRequest : TeaModel {
        /// <summary>
        /// <para>The service supported by enhanced document moderation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document_detection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The set of parameters required for the moderation service. The value must be a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>url: Required. The URL of the object to be moderated. Make sure that the URL can be accessed over the Internet.</description></item>
        /// <item><description>dataId: Optional. The data ID that corresponds to the moderated object.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;url&quot;:&quot;<a href="https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.pdf%22%7D">https://detect-obj.oss-cn-hangzhou.aliyuncs.com/sample/xxxx.pdf&quot;}</a></para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
