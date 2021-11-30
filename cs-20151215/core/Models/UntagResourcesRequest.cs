// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// 是否删除全部自定义标签，仅当tag_keys为空时生效，取值：[true,false]。
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// 资源所属的地域ID
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 资源ID。数组长度取值范围为：1~50
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 资源类型定义。取值范围： 只支持CLUSTER这一种资源类型
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源的标签键。N的取值范围：1~20
        /// </summary>
        [NameInMap("tag_keys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
