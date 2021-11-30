// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusRequest : TeaModel {
        /// <summary>
        /// 是否包含转发规则健康检查结果
        /// </summary>
        [NameInMap("IncludeRule")]
        [Validation(Required=false)]
        public bool? IncludeRule { get; set; }

        /// <summary>
        /// 监听Id
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
