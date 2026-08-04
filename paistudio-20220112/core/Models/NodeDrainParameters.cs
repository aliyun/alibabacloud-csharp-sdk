// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeDrainParameters : TeaModel {
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Delete pods of the specified job types</para>
        /// </summary>
        [NameInMap("PodFromSubProducts")]
        [Validation(Required=false)]
        public List<string> PodFromSubProducts { get; set; }

        /// <summary>
        /// <para>Delete specified pods</para>
        /// </summary>
        [NameInMap("PodNames")]
        [Validation(Required=false)]
        public List<string> PodNames { get; set; }

    }

}
