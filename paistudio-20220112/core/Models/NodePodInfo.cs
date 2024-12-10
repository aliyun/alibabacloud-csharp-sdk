// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodePodInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.2.2</para>
        /// </summary>
        [NameInMap("PodIP")]
        [Validation(Required=false)]
        public string PodIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PodNamespace")]
        [Validation(Required=false)]
        public string PodNamespace { get; set; }

        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public ResourceAmount ResourceSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc19de9s6vn3acr</para>
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}
