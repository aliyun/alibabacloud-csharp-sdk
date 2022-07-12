// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCheckPointRequest : TeaModel {
        /// <summary>
        /// Shard ID。
        /// 如果指定的Shard不存在，则返回空列表。
        /// 如果不指定Shard，则返回所有Shard的checkpoint。
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

    }

}
