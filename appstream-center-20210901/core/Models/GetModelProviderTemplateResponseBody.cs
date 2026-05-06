// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetModelProviderTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetModelProviderTemplateResponseBodyData Data { get; set; }
        public class GetModelProviderTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;api&quot;: &quot;openai-completions&quot;,
            ///     &quot;apiKey&quot;: &quot;sk-xxxx&quot;,
            ///     &quot;baseUrl&quot;: &quot;<a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a>&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableWuyingProxy")]
            [Validation(Required=false)]
            public bool? EnableWuyingProxy { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mpt-xxxx</para>
            /// </summary>
            [NameInMap("ProviderTemplateId")]
            [Validation(Required=false)]
            public string ProviderTemplateId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
