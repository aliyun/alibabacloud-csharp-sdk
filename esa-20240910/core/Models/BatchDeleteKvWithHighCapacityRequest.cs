// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchDeleteKvWithHighCapacityRequest : TeaModel {
        /// <summary>
        /// <para>The namespace name specified when you called <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The download URL that contains the key-value pairs to be batch deleted, such as an OSS download URL with read permissions.</para>
        /// <list type="bullet">
        /// <item><description><para>When you call this operation by using the SDK, the SDK automatically uploads the content to OSS and passes the corresponding URL.</para>
        /// </description></item>
        /// <item><description><para>To call this operation directly, upload the JSON payload (in the same format as the BatchDeleteKv body: {&quot;Namespace&quot;:&quot;...&quot;,&quot;Keys&quot;:[...]}) to an OSS bucket and generate a signed HTTPS GET URL.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxobject.oss-cn-region.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7">https://xxxobject.oss-cn-region.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
