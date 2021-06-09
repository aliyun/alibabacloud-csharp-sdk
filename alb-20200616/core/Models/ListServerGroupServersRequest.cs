// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupServersRequest : TeaModel {
        /// <summary>
        /// 分页查询标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 服务器组id
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public List<string> ServerIds { get; set; }

    }

}
