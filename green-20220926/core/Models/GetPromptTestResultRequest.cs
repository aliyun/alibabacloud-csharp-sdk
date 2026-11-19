// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetPromptTestResultRequest : TeaModel {
        /// <summary>
        /// <para>The configuration item. Note: This parameter is actually required. If it is not provided, the service returns a 400 error (config may not be empty).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;enable\&quot;:false}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The resource type. Note: This parameter is actually required. If it is not provided, the service returns a 400 error (resourceType may not be empty).</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The service code. Note: This parameter is actually required. If it is not provided, the service returns a 400 error (serviceCode may not be empty).</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The text content. Note: This parameter is actually required. If it is not provided, the service returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test text</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The business type. Note: This parameter is actually required. If it is not provided, the service returns a 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_llm_template</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
