// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListOperationPlansForRegionRequest : TeaModel {
        /// <summary>
        /// <para>Filter by cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c02b3e03be10643e8a644a843ffcb****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Filter by execution plan status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>Filter by execution plan type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER_UPGRADE_MASTER</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
