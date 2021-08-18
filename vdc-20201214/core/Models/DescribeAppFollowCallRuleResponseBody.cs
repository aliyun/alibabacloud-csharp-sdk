// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeAppFollowCallRuleResponseBody : TeaModel {
        /// <summary>
        /// 获取用户体验阈值规则相关数据
        /// </summary>
        [NameInMap("AppFollowCallRule")]
        [Validation(Required=false)]
        public DescribeAppFollowCallRuleResponseBodyAppFollowCallRule AppFollowCallRule { get; set; }
        public class DescribeAppFollowCallRuleResponseBodyAppFollowCallRule : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }
            [NameInMap("ModifiedTs")]
            [Validation(Required=false)]
            public long? ModifiedTs { get; set; }
            [NameInMap("GmtCreateTs")]
            [Validation(Required=false)]
            public long? GmtCreateTs { get; set; }
            [NameInMap("GmtModifiedTs")]
            [Validation(Required=false)]
            public long? GmtModifiedTs { get; set; }
        };

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
