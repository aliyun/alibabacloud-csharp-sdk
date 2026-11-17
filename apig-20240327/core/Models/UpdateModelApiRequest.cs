// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The API access prefix. The default value is / during creation. If omitted during an update, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/beta</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The description of the model API. If omitted during an update, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model API for business integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable direct supply fallback. If omitted during an update, the original value is retained. Explicitly set to false to disable it.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("directSupplyFallbackEnabled")]
        [Validation(Required=false)]
        public bool? DirectSupplyFallbackEnabled { get; set; }

        /// <summary>
        /// <para>The IDs of the selected custom or default domain names of the instance. This parameter must be explicitly non-empty during creation. If omitted during an update, the original value is retained. When submitted, the entire list is replaced and cannot be empty.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable consumer API key authentication. If omitted during an update, the original value is retained. The type is fixed to Apikey or Custom.</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The time to first byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("firstByteTimeout")]
        [Validation(Required=false)]
        public int? FirstByteTimeout { get; set; }

        /// <summary>
        /// <para>The model selection. This parameter is required during creation. If omitted during an update, the original value is retained. When submitted, the entire selection is replaced.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("modelSelection")]
        [Validation(Required=false)]
        public ModelSelection ModelSelection { get; set; }

        /// <summary>
        /// <para>Supported only by the new version of ModelAPI in minimalist mode: merges the actual source model IDs added to or removed from the model source in this request into the latest selection within the lock. This parameter is mutually exclusive with modelSelection and cannot be null or an empty delta. The standard update and publish process applies.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("modelSelectionDelta")]
        [Validation(Required=false)]
        public ModelSelectionDelta ModelSelectionDelta { get; set; }

        /// <summary>
        /// <para>The name of the model API. If omitted or set to null, the original value is retained. When submitted, the value is trimmed of leading and trailing whitespace, must be non-empty, contain a maximum of 128 UTF-8 bytes, and cannot contain @ or /. Renaming the API does not change the API ID or access prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-model-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configurations for AI request logs and AI security protection. If omitted during an update, the original values are retained. When submitted, the inline policies of both types are entirely replaced. An empty array clears both types. Independent token quotas are not affected.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<ModelApiPolicyConfig> PolicyConfigs { get; set; }

    }

}
