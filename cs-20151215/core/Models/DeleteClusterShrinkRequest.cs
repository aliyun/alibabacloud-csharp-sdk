// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterShrinkRequest : TeaModel {
        /// <summary>
        /// 是否保留所有资源,如果设置了该值，将会忽略retain_resources。  true：保留 false：不保留 默认值：fase。
        /// </summary>
        [NameInMap("retain_all_resources")]
        [Validation(Required=false)]
        public bool? RetainAllResources { get; set; }

        /// <summary>
        /// 是否保留SLB。  true：保留 false：不保留 默认值：false。
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// 要保留的资源列表。
        /// </summary>
        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public string RetainResourcesShrink { get; set; }

    }

}
