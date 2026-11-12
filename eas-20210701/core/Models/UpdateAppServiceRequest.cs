// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateAppServiceRequest : TeaModel {
        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The application version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <para>The additional configuration information required for deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;ModelStorage&quot;: &quot;oss&quot;, &quot;OssPath&quot;: &quot;oss://examplebucket/xxxx/&quot; }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The number of instances. The value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para>The service specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>llama_7b_fp16</description></item>
        /// <item><description>llama_7b_int8</description></item>
        /// <item><description>llama_13b_fp16</description></item>
        /// <item><description>llama_7b_int8</description></item>
        /// <item><description>chatglm_6b_fp16</description></item>
        /// <item><description>chatglm_6b_int8</description></item>
        /// <item><description>chatglm2_6b_fp16</description></item>
        /// <item><description>baichuan_7b_int8</description></item>
        /// <item><description>baichuan_13b_fp16</description></item>
        /// <item><description>baichuan_7b_fp16</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>llama_7b_fp16</para>
        /// </summary>
        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public string ServiceSpec { get; set; }

    }

}
