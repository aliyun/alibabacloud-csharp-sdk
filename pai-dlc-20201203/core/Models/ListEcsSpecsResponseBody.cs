// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListEcsSpecsResponseBody : TeaModel {
        /// <summary>
        /// ECS规格列表
        /// </summary>
        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<EcsSpec> EcsSpecs { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 符合过滤条件的总数量
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
