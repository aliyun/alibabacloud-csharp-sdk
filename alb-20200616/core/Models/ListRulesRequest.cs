// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesRequest : TeaModel {
        /// <summary>
        /// 用来标记当前开始读取的位置，置空表示从头开始。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量，此参数为可选参数，取值1-100，用户传入为空时，默认为20。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 转发规则ID列表，N最大支持20
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<string> RuleIds { get; set; }

        /// <summary>
        /// 监听ID列表
        /// </summary>
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

    }

}
