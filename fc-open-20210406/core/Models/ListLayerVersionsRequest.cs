// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListLayerVersionsRequest : TeaModel {
        /// <summary>
        /// 本次读取的最大数据记录数量
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// 起始版本
        /// </summary>
        [NameInMap("startVersion")]
        [Validation(Required=false)]
        public int? StartVersion { get; set; }

    }

}
