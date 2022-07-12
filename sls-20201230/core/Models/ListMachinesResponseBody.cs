// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMachinesResponseBody : TeaModel {
        /// <summary>
        /// 当前页返回的机器数目。
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// 返回的机器信息列表。
        /// </summary>
        [NameInMap("machines")]
        [Validation(Required=false)]
        public List<Machine> Machines { get; set; }

        /// <summary>
        /// 机器总数。
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
