// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeAppFollowCallRuleListResponseBody : TeaModel {
        /// <summary>
        /// 通信监测关注规则相关数据列表
        /// </summary>
        [NameInMap("AppFollowCallRuleList")]
        [Validation(Required=false)]
        public List<DescribeAppFollowCallRuleListResponseBodyAppFollowCallRuleList> AppFollowCallRuleList { get; set; }
        public class DescribeAppFollowCallRuleListResponseBodyAppFollowCallRuleList : TeaModel {
            /// <summary>
            /// 应用ID
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// 创建时间，秒级时间戳，如1614836732
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// 创建时间，待删除
            /// </summary>
            [NameInMap("GmtCreateTs")]
            [Validation(Required=false)]
            public long? GmtCreateTs { get; set; }

            /// <summary>
            /// 修改时间，待删除
            /// </summary>
            [NameInMap("GmtModifiedTs")]
            [Validation(Required=false)]
            public long? GmtModifiedTs { get; set; }

            /// <summary>
            /// 修改时间，秒级时间戳，如1614836732
            /// </summary>
            [NameInMap("ModifiedTs")]
            [Validation(Required=false)]
            public long? ModifiedTs { get; set; }

            /// <summary>
            /// 具体规则，JSON格式
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
