// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateModelApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The model category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-09T06:43:33Z</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-09T06:43:33Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The invocation endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://model-api.example.com/v1/chat/completions">https://model-api.example.com/v1/chat/completions</a></para>
        /// </summary>
        [NameInMap("InvokeEndpoint")]
        [Validation(Required=false)]
        public string InvokeEndpoint { get; set; }

        /// <summary>
        /// <para>The model API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelApiId")]
        [Validation(Required=false)]
        public string ModelApiId { get; set; }

        /// <summary>
        /// <para>The saved model name mappings, returned as a JSON array string. This parameter is empty if no mappings are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Source&quot;:&quot;client-model-a&quot;,&quot;Target&quot;:&quot;upstream-model-a&quot;}]</para>
        /// </summary>
        [NameInMap("ModelMappings")]
        [Validation(Required=false)]
        public string ModelMappings { get; set; }

        /// <summary>
        /// <para>The name of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jev-chat-api</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The invocation path prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/jev/v1</para>
        /// </summary>
        [NameInMap("PathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// <para>The access protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai-chat</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The saved routing rules, returned as a JSON string. A byte-by-byte exact echo is not guaranteed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RuleName&quot;:&quot;default&quot;,&quot;Providers&quot;:[{&quot;ModelServiceName&quot;:&quot;model-service-a&quot;,&quot;ModelList&quot;:&quot;[\&quot;deepseek-v4-pro\&quot;]&quot;,&quot;Weight&quot;:100}]}]</para>
        /// </summary>
        [NameInMap("RouteRules")]
        [Validation(Required=false)]
        public string RouteRules { get; set; }

        /// <summary>
        /// <para>The status of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
