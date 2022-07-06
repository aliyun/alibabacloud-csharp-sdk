// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// 查询的资源的 id 列表。resource id 与 tags 应至少存在一个。
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// 资源类型。目前取值范围：project。
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 精确查找时过滤的标签键值对。resource id 与 tags 应至少存在一个。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTags> Tags { get; set; }
        public class ListTagResourcesRequestTags : TeaModel {
            /// <summary>
            /// 精确过滤的标签的键。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 精确过滤的标签的值。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
