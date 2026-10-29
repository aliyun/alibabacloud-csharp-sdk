// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DashScopeTransformParameters : TeaModel {
        /// <summary>
        /// <para>The API key for DashScope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Q37sQ****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The prompts.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<DashScopeTransformParametersMessages> Messages { get; set; }
        public class DashScopeTransformParametersMessages : TeaModel {
            /// <summary>
            /// <para>The template form.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The template value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.message</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The rate limit in requests per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RequestPerMinute")]
        [Validation(Required=false)]
        public long? RequestPerMinute { get; set; }

        /// <summary>
        /// <para>The structured output schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;message&quot;:{&quot;type&quot;:&quot;string&quot;}},&quot;required&quot;:[&quot;message&quot;]}</para>
        /// </summary>
        [NameInMap("StructuredOutputJsonSchema")]
        [Validation(Required=false)]
        public string StructuredOutputJsonSchema { get; set; }

        /// <summary>
        /// <para>The rate limit in tokens per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("TokenPerMinute")]
        [Validation(Required=false)]
        public long? TokenPerMinute { get; set; }

    }

}
