// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceMirrorRequest : TeaModel {
        /// <summary>
        /// 比例 [0, 100]
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// 服务实例列表
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public List<string> Target { get; set; }

    }

}
