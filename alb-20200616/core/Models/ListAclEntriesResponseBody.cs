// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclEntriesResponseBody : TeaModel {
        /// <summary>
        /// 访问控制列表
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<ListAclEntriesResponseBodyAclEntries> AclEntries { get; set; }
        public class ListAclEntriesResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// 描述信息
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// IP条目
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 本次查询返回记录数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页查询标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
