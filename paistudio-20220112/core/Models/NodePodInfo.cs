// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodePodInfo : TeaModel {
        /// <summary>
        /// <para>The occupied GPU indexes.</para>
        /// </summary>
        [NameInMap("GPUIndexes")]
        [Validation(Required=false)]
        public List<int?> GPUIndexes { get; set; }

        /// <summary>
        /// <para>The Pod status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The IP address of the Pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.2.2</para>
        /// </summary>
        [NameInMap("PodIP")]
        [Validation(Required=false)]
        public string PodIP { get; set; }

        /// <summary>
        /// <para>The Pod name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

        /// <summary>
        /// <para>The namespace of the Pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PodNamespace")]
        [Validation(Required=false)]
        public string PodNamespace { get; set; }

        /// <summary>
        /// <para>The resource usage information.</para>
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public ResourceAmount ResourceSpec { get; set; }

        /// <summary>
        /// <para>The task ID or service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc19de9s6vn3acr</para>
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// <para>The sub-product that the Pod belongs to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}
