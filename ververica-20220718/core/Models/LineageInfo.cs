// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class LineageInfo : TeaModel {
        /// <summary>
        /// <para>The edge information.</para>
        /// </summary>
        [NameInMap("edges")]
        [Validation(Required=false)]
        public Edge Edges { get; set; }

        /// <summary>
        /// <para>The deployments.</para>
        /// </summary>
        [NameInMap("jobInfos")]
        [Validation(Required=false)]
        public List<JobInfo> JobInfos { get; set; }

        /// <summary>
        /// <para>The nodes.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<Node> Nodes { get; set; }

    }

}
