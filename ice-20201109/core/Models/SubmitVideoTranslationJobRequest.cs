// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitVideoTranslationJobRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test ClientToken</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Configuration parameters for the video translation job, specified as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SourceLanguage&quot;:&quot;zh&quot;,&quot;TargetLanguage&quot;:&quot;en&quot;,&quot;DetextArea&quot;:&quot;Auto&quot;}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input parameters for the video translation job.</para>
        /// <list type="bullet">
        /// <item><description><para>The input can be a video or a subtitle file.</para>
        /// </description></item>
        /// <item><description><para>The value must be a JSON string.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;Video&quot;,&quot;Video&quot;:&quot;1628ae20c36******8f6f7c77a6302&quot;}</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>Output parameters for the video translation job. The output can be a video or a subtitle file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;: &quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/your-object.mp4%22%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/your-object.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>The system automatically populates this parameter. You do not need to set it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto-complete, no need to write</para>
        /// </summary>
        [NameInMap("SignatureMehtod")]
        [Validation(Required=false)]
        public string SignatureMehtod { get; set; }

        [NameInMap("SignatureNonce")]
        [Validation(Required=false)]
        public string SignatureNonce { get; set; }

        /// <summary>
        /// <para>The system automatically populates this parameter. You do not need to set it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto-complete, no need to write</para>
        /// </summary>
        [NameInMap("SignatureType")]
        [Validation(Required=false)]
        public string SignatureType { get; set; }

        [NameInMap("SignatureVersion")]
        [Validation(Required=false)]
        public string SignatureVersion { get; set; }

        /// <summary>
        /// <para>The job title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>User data for the job, provided as a JSON string. The string can be up to 512 bytes long.</para>
        /// <list type="bullet">
        /// <item><description>Use this parameter to <a href="https://help.aliyun.com/document_detail/451631.html">configure a custom callback URL</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
