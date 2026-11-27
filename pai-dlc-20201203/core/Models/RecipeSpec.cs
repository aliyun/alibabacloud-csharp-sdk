// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RecipeSpec : TeaModel {
        /// <summary>
        /// <para>The CPU specification of a single pod, represented as a Kubernetes quantity string such as &quot;4&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// <para>The name of the ECS instance specification. This field is not supported when starting an RLJob. Omit this field. A non-empty value returns Recipe.InvalidParameter. The example only illustrates the name format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.gn7i-c8g1.2xlarge</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// <para>The number of GPUs for a single pod, such as &quot;1&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// <para>The GPU type, such as &quot;A100&quot;. You can obtain the supported values from the existing quota or specification API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A100</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The memory specification of a single pod, represented as a Kubernetes quantity string such as &quot;8Gi&quot;. This refers to the host memory rather than the GPU memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8Gi</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// <para>The number of pods for the entry. The default value is 1. This parameter takes effect only when the value is greater than 0. Otherwise, the downstream RLJob uses the default value of 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PodCount")]
        [Validation(Required=false)]
        public int? PodCount { get; set; }

        /// <summary>
        /// <para>The quota ID. The current RLJob startup path requires a single quota. Multiple quotas are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotag2uo09dyp40</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The shared memory specification of a single pod, represented as a Kubernetes quantity string such as &quot;4Gi&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4Gi</para>
        /// </summary>
        [NameInMap("SharedMemory")]
        [Validation(Required=false)]
        public string SharedMemory { get; set; }

    }

}
