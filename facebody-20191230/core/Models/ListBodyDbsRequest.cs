// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListBodyDbsRequest : TeaModel {
        /// <summary>
        /// 起始位置(不含)
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long Offset { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long Limit { get; set; }

    }

}
