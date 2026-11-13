// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The access prefix of the API. The default value is / when the API is created. If this parameter is omitted in an update request, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/beta</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The description of the model API. If this parameter is omitted in an update request, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model API for business integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable direct supply fallback. If this parameter is omitted in an update request, the original value is retained. Explicitly setting this parameter to false disables the feature.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("directSupplyFallbackEnabled")]
        [Validation(Required=false)]
        public bool? DirectSupplyFallbackEnabled { get; set; }

        /// <summary>
        /// <para>The IDs of the selected custom domain names or the default domain name of the instance. This parameter must be explicitly specified and cannot be empty when the API is created. If this parameter is omitted in an update request, the original value is retained. When submitted, the entire list is replaced and cannot be empty.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable API key authentication for consumers. If this parameter is omitted in an update request, the original value is retained. The type is fixed to Apikey or Custom.</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The time to first byte (TTFB) timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("firstByteTimeout")]
        [Validation(Required=false)]
        public int? FirstByteTimeout { get; set; }

        /// <summary>
        /// <para>The model selection. This parameter is required when the API is created. If this parameter is omitted in an update request, the original value is retained. When submitted, the entire configuration is replaced.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("modelSelection")]
        [Validation(Required=false)]
        public ModelSelection ModelSelection { get; set; }

        /// <summary>
        /// <para>The name of the model API. If this parameter is omitted or set to null, the original value is retained. When submitted, the value is trimmed of leading and trailing whitespace and must not be empty. The value can be up to 128 UTF-8 bytes in length and cannot contain at signs (@) or forward slashes (/). Changing the name does not change the API ID or the access prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-model-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configurations for AI request logs and AI security protection only. If this parameter is omitted in an update request, the original value is retained. When submitted, the inline policies of both types are entirely replaced. An empty array clears both types of policies. Independent token quotas are not affected.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<ModelApiPolicyConfig> PolicyConfigs { get; set; }

    }

}
