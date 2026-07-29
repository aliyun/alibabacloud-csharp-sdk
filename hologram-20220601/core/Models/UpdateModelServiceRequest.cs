// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateModelServiceRequest : TeaModel {
        /// <summary>
        /// <para>The CPU specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The GPU specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("gpu")]
        [Validation(Required=false)]
        public long? Gpu { get; set; }

        /// <summary>
        /// <para>The memory specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        /// <summary>
        /// <para>A custom name for the model service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-qwen</para>
        /// </summary>
        [NameInMap("modelServiceName")]
        [Validation(Required=false)]
        public string ModelServiceName { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen/Qwen2.5-VL-32B-Instruct</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The number of service replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("serviceCount")]
        [Validation(Required=false)]
        public long? ServiceCount { get; set; }

    }

}
