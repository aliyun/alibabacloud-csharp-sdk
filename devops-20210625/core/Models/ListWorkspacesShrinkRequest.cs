// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkspacesShrinkRequest : TeaModel {
        /// <summary>
        /// 本次读取的最大数据记录数量，默认10，最大100
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 用来标记当前开始读取的位置，置空表示从头开始
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 枚举值：CREATING-创建中, SUCCESS-运行中, FROZEN-冻结中, RECOVERING-恢复中
        /// </summary>
        [NameInMap("statusList")]
        [Validation(Required=false)]
        public string StatusListShrink { get; set; }

        /// <summary>
        /// 空间模板列表
        /// </summary>
        [NameInMap("workspaceTemplateList")]
        [Validation(Required=false)]
        public string WorkspaceTemplateListShrink { get; set; }

    }

}
