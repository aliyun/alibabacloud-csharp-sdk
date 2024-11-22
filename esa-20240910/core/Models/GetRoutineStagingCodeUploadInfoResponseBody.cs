// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineStagingCodeUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The code version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710120201067203242</para>
        /// </summary>
        [NameInMap("CodeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        /// <summary>
        /// <para>The configuration information that can be used to upload to OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///             &quot;Url&quot;: &quot;<a href="http://oss_fake_bucket_url">http://oss_fake_bucket_url</a>&quot;,
        ///             &quot;OSSAccessKeyId&quot;: &quot;xxx&quot;,
        ///             &quot;key&quot;: &quot;site_er_js/hello.1418586423220543.unstable.js&quot;,
        ///             &quot;callback&quot;: &quot;xxx==&quot;,
        ///             &quot;x:codeDescription&quot;: &quot;xxx=&quot;,
        ///             &quot;policy&quot;: &quot;xxx&quot;,
        ///             &quot;Signature&quot;: &quot;xxx=&quot;
        /// }</para>
        /// </summary>
        [NameInMap("OssPostConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> OssPostConfig { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
