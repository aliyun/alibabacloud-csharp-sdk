// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeResource : TeaModel {
        /// <summary>
        /// <para>The resource pool type. Valid values: train, eval, and inference. If left empty, the storage layer uses the default value based on the associated slot. For training child tables, TrainResource must be set to train and InferenceResource must be set to inference. For evaluation child tables, the resource must be set to eval. Cross-type sharing is not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The JSON array of resource specifications. It uses the CustomJob resource shape (flat pod_count, ecs_spec, cpu, memory, gpu, gpu_type, shared_memory, and quota_id). It is required and passed through as-is. Currently, the path that starts an RLJob from a Recipe only consumes a single train specification and a single quota, and does not support ecs_spec. Support for multiple specifications, multiple quotas, and ecs_spec will be available when the RLJob side enables these features.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;PodCount&quot;:1,&quot;CPU&quot;:&quot;4&quot;,&quot;Memory&quot;:&quot;8Gi&quot;,&quot;GPU&quot;:&quot;1&quot;,&quot;GPUType&quot;:&quot;A100&quot;,&quot;QuotaId&quot;:&quot;quotag2uo09dyp40&quot;}]</para>
        /// </summary>
        [NameInMap("Specs")]
        [Validation(Required=false)]
        public List<RecipeSpec> Specs { get; set; }

    }

}
