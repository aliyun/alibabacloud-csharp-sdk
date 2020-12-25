// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterTagsRequest : TeaModel {
        /// <summary>
        /// 集群标签列表。
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<Tag> Body { get; set; }

    }

}
