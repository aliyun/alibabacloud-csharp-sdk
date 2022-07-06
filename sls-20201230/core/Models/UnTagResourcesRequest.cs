// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UnTagResourcesRequest : TeaModel {
        /// <summary>
        /// 是否删除所有标签，默认为 false，表示仅删除 tags 列表中的标签项。值为 true 时删除资源上绑定的所有标签。
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// 资源的 id 列表，可以一次为多个同类型资源删除相同的标签。当 all 为 false 时生效。
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// 资源的类型。目前取值范围 ： project。
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 标签 key 列表。当 all 为 false 时，仅删除列表中的标签。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
