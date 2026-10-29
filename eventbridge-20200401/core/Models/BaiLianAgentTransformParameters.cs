// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class BaiLianAgentTransformParameters : TeaModel {
        /// <summary>
        /// <para>The API key for Model Studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Q34****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The prompt.</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public BaiLianAgentTransformParametersPrompt Prompt { get; set; }
        public class BaiLianAgentTransformParametersPrompt : TeaModel {
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
        /// <para>The throttling limit in requests per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RequestPerMinute")]
        [Validation(Required=false)]
        public long? RequestPerMinute { get; set; }

        /// <summary>
        /// <para>The throttling limit in tokens per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("TokenPerMinute")]
        [Validation(Required=false)]
        public long? TokenPerMinute { get; set; }

    }

}
