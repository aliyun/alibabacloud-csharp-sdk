// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeAppExpMetricRuleListResponseBody : TeaModel {
        /// <summary>
        /// 用户体验阈值规则相关数据列表
        /// </summary>
        [NameInMap("AppExpMetricRuleList")]
        [Validation(Required=false)]
        public List<DescribeAppExpMetricRuleListResponseBodyAppExpMetricRuleList> AppExpMetricRuleList { get; set; }
        public class DescribeAppExpMetricRuleListResponseBodyAppExpMetricRuleList : TeaModel {
            /// <summary>
            /// 应用ID
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// 创建时间，秒级时间戳，如1614912647
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            [NameInMap("GmtCreateTs")]
            [Validation(Required=false)]
            public long? GmtCreateTs { get; set; }

            [NameInMap("GmtModifiedTs")]
            [Validation(Required=false)]
            public long? GmtModifiedTs { get; set; }

            /// <summary>
            /// 修改时间，秒级时间戳，如1615272998
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
