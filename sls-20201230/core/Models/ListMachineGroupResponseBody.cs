// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMachineGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of machine groups that are returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The machine groups that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ &quot;test-machine-group-1&quot;, &quot;test-machine-group-2&quot; ]</para>
        /// </summary>
        [NameInMap("machinegroups")]
        [Validation(Required=false)]
        public List<string> Machinegroups { get; set; }

        /// <summary>
        /// <para>The total number of machine groups that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
