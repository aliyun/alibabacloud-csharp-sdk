// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// 下一个版本。
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 资源ID。
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// 按标签查找。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// 资源类型，例如：SLB。
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
