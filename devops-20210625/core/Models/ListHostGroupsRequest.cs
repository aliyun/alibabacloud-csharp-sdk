// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListHostGroupsRequest : TeaModel {
        /// <summary>
        /// 主机组结束时间
        /// </summary>
        [NameInMap("createEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// 主机组创建时间
        /// </summary>
        [NameInMap("createStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        /// <summary>
        /// 创建阿里云账号id，多个逗号分割
        /// </summary>
        [NameInMap("creatorAccountIds")]
        [Validation(Required=false)]
        public string CreatorAccountIds { get; set; }

        /// <summary>
        /// 主机组id，多个逗号分割
        /// </summary>
        [NameInMap("ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// 结果返回个数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 主机组名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 分页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [NameInMap("pageOrder")]
        [Validation(Required=false)]
        public string PageOrder { get; set; }

        /// <summary>
        /// 排序条件ID
        /// </summary>
        [NameInMap("pageSort")]
        [Validation(Required=false)]
        public string PageSort { get; set; }

    }

}
