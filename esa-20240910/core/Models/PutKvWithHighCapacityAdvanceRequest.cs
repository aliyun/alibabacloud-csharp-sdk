// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class PutKvWithHighCapacityAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The key name to set. The key name can be up to 512 characters in length and cannot contain spaces or backslashes (/).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_key</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The name specified when you called the <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namesapce</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>A publicly accessible HTTP or HTTPS URL that points to a JSON file containing the key-value pair to set. The server actively downloads the content from this URL.</para>
        /// <list type="bullet">
        /// <item><description><para>If you use an SDK, the SDK automatically uploads the file and generates the URL.</para>
        /// </description></item>
        /// <item><description><para>In non-SDK scenarios, upload the JSON payload to any publicly accessible HTTP service and specify the URL.</para>
        /// </description></item>
        /// </list>
        /// <para>The file content pointed to by the URL must be in the following JSON format: {&quot;Namespace&quot;:&quot;<namespace>&quot;,&quot;Key&quot;:&quot;<key>&quot;,&quot;Value&quot;:&quot;<value>&quot;}.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxobject.oss-cn-region.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7">https://xxxobject.oss-cn-region.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public Stream UrlObject { get; set; }

    }

}
