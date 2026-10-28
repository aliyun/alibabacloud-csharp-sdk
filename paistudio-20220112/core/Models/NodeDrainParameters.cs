// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeDrainParameters : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly drain the node.</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The pods of the specified job types to drain.</para>
        /// </summary>
        [NameInMap("PodFromSubProducts")]
        [Validation(Required=false)]
        public List<string> PodFromSubProducts { get; set; }

        /// <summary>
        /// <para>The specified pods to drain.</para>
        /// </summary>
        [NameInMap("PodNames")]
        [Validation(Required=false)]
        public List<string> PodNames { get; set; }

    }

}
