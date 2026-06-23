// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchPutKvWithHighCapacityRequest : TeaModel {
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
        /// <para>A publicly accessible HTTP(S) URL that points to a JSON file containing the key-value pairs to be batch set. The server actively downloads the content from this URL.</para>
        /// <list type="bullet">
        /// <item><description><para>If you use an SDK, the SDK automatically uploads the file and generates the URL.</para>
        /// </description></item>
        /// <item><description><para>In non-SDK scenarios, upload the JSON payload to any publicly accessible HTTP service and specify the URL.</para>
        /// </description></item>
        /// </list>
        /// <para>The file content pointed to by the URL must be in the following JSON format: {&quot;Namespace&quot;:&quot;<namespace name>&quot;,&quot;KvList&quot;:[{&quot;Key&quot;:&quot;<key>&quot;,&quot;Value&quot;:&quot;<value>&quot;},...]}.If the URL content does not match this format, the API silently returns an empty SuccessKeys array.</para>
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
