// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The access prefix of the API. The default value is / when created. If omitted in an update request, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/beta</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The description of the model API. If omitted in an update request, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model API for business integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the direct supply fallback. If omitted in an update request, the original value is retained. Set to false to explicitly disable it.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("directSupplyFallbackEnabled")]
        [Validation(Required=false)]
        public bool? DirectSupplyFallbackEnabled { get; set; }

        /// <summary>
        /// <para>The IDs of the selected custom or instance default domain names. This parameter must be explicitly set to a non-empty value when creating an API. If omitted in an update request, the original value is retained. When submitted, the entire list is replaced and cannot be empty.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable consumer API key authentication. If omitted in an update request, the original value is retained. The type is fixed to Apikey or Custom.</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The first byte timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("firstByteTimeout")]
        [Validation(Required=false)]
        public int? FirstByteTimeout { get; set; }

        /// <summary>
        /// <para>The model selection. This parameter is required when creating an API. If omitted in an update request, the original value is retained. When submitted, the entire selection is replaced.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("modelSelection")]
        [Validation(Required=false)]
        public ModelSelection ModelSelection { get; set; }

        /// <summary>
        /// <para>Supported only by the new version of Model API in minimalist mode. Merges the actual source model IDs added or removed in this request into the latest locked selection. This parameter is mutually exclusive with modelSelection and cannot be null or an empty delta. The standard update and publish process applies.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("modelSelectionDelta")]
        [Validation(Required=false)]
        public ModelSelectionDelta ModelSelectionDelta { get; set; }

        /// <summary>
        /// <para>The name of the model API. If omitted or set to null, the original value is retained. When submitted, the name is trimmed of leading and trailing whitespace, must not be empty, can be up to 128 UTF-8 bytes in length, and cannot contain the at sign (@) or forward slash (/). Renaming the API does not change the API ID or the access prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-model-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy configurations for AI request logging and AI security protection only. If omitted in an update request, the original values are retained. When submitted, the inline policies of both types are entirely replaced. An empty array clears both types of policies. Independent token quotas are not affected.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<ModelApiPolicyConfig> PolicyConfigs { get; set; }

    }

}
