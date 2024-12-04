// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAppliedMachineGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of returned machine groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The names of the returned machine groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;sample-group1&quot;,&quot;sample-group2&quot; ]</para>
        /// </summary>
        [NameInMap("machinegroups")]
        [Validation(Required=false)]
        public List<string> Machinegroups { get; set; }

    }

}
