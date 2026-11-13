// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ClusterState : TeaModel {
        /// <summary>
        /// <para>The stage progress information for cluster operations.</para>
        /// </summary>
        [NameInMap("ClusterStage")]
        [Validation(Required=false)]
        public ClusterStage ClusterStage { get; set; }

        /// <summary>
        /// <para>The cluster running status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The cluster running sub-status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

    }

}
