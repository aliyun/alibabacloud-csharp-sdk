// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSprintsRequest : TeaModel {
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
        /// 项目id
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

    }

}
