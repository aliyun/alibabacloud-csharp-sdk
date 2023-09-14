// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingConstraints : TeaModel {
        /// <summary>
        /// 最大值。
        /// </summary>
        [NameInMap("MaxCapacity")]
        [Validation(Required=false)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// 最小值。
        /// </summary>
        [NameInMap("MinCapacity")]
        [Validation(Required=false)]
        public int? MinCapacity { get; set; }

    }

}
