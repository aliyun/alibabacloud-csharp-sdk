// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListOnDemandConfigsResponseBody : TeaModel {
        /// <summary>
        /// 预留实例配置
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<OnDemandConfig> Configs { get; set; }

        /// <summary>
        /// 用来返回更多的查询结果。如果这个值没有返回，则说明没有更多结果。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
