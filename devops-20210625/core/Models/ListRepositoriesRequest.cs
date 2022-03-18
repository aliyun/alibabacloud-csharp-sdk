// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoriesRequest : TeaModel {
        /// <summary>
        /// accessToken
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 是否列出归档项目
        /// </summary>
        [NameInMap("archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [NameInMap("perPage")]
        [Validation(Required=false)]
        public long? PerPage { get; set; }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// 排序方式 (desc: 降序, asc: 升序)
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
