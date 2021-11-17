// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListEcsSpecsResponseBody : TeaModel {
        /// <summary>
        /// 请求ecs规格列表
        /// </summary>
        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<EcsSpec> EcsSpecs { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 符合要求的ecs规格数量
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
