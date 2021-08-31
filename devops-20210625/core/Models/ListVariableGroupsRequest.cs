// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListVariableGroupsRequest : TeaModel {
        /// <summary>
        /// 排序条件
        /// </summary>
        [NameInMap("pageSort")]
        [Validation(Required=false)]
        public string PageSort { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [NameInMap("pageOrder")]
        [Validation(Required=false)]
        public string PageOrder { get; set; }

        /// <summary>
        /// 分页token，上一次请求的出参nextToken
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 最大返回数，默认30
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
