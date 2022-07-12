// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMachineGroupResponseBody : TeaModel {
        /// <summary>
        /// 当前页返回的机器组数量。
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// 机器组名称列表。
        /// </summary>
        [NameInMap("machinegroups")]
        [Validation(Required=false)]
        public List<string> Machinegroups { get; set; }

        /// <summary>
        /// 机器组总数量。
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
