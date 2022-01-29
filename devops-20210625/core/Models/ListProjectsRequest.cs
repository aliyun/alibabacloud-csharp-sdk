// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectsRequest : TeaModel {
        /// <summary>
        /// 项目类型
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        [NameInMap("extraConditions")]
        [Validation(Required=false)]
        public string ExtraConditions { get; set; }

        /// <summary>
        /// 每页最大返回数量，0-200，默认值20
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 分页中的起始序列
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 公开类型
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
