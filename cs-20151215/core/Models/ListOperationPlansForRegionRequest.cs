// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListOperationPlansForRegionRequest : Darabonba.Model {
        /// <summary>
        /// <para>Filters the results by cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c02b3e03be10643e8a644a843ffcb****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Filters the results by execution plan state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>Filters the results by execution plan type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER_UPGRADE_MASTER</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

