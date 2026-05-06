// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateModelProviderTemplateRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public UpdateModelProviderTemplateRequestConfig Config { get; set; }
        public class UpdateModelProviderTemplateRequestConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>openai-completions</para>
            /// </summary>
            [NameInMap("ApiType")]
            [Validation(Required=false)]
            public string ApiType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

        }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mpt-xxxx</para>
        /// </summary>
        [NameInMap("ProviderTemplateId")]
        [Validation(Required=false)]
        public string ProviderTemplateId { get; set; }

    }

}
