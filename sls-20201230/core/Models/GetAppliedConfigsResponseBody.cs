// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAppliedConfigsResponseBody : TeaModel {
        /// <summary>
        /// Logtail配置名称列表。
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<string> Configs { get; set; }

        /// <summary>
        /// Logtail配置数量。
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
