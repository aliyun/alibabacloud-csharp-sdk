// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupsRequest : TeaModel {
        /// <summary>
        /// 查询数量
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
        /// 资源组ID
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// 服务器组Id列表
        /// </summary>
        [NameInMap("ServerGroupIds")]
        [Validation(Required=false)]
        public List<string> ServerGroupIds { get; set; }

        /// <summary>
        /// 服务器组名称
        /// </summary>
        [NameInMap("ServerGroupNames")]
        [Validation(Required=false)]
        public List<string> ServerGroupNames { get; set; }

        /// <summary>
        /// Tag列表
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServerGroupsRequestTag> Tag { get; set; }
        public class ListServerGroupsRequestTag : TeaModel {
            /// <summary>
            /// 标签键
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签值
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// VpcId
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
