// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobElasticSpec : TeaModel {
        /// <summary>
        /// aimaster角色使用的资源规格
        /// </summary>
        [NameInMap("AIMasterType")]
        [Validation(Required=false)]
        public string AIMasterType { get; set; }

        /// <summary>
        /// 打开弹性训练
        /// </summary>
        [NameInMap("EnableElasticTraining")]
        [Validation(Required=false)]
        public bool? EnableElasticTraining { get; set; }

        /// <summary>
        /// 最大并行度
        /// </summary>
        [NameInMap("MaxParallelism")]
        [Validation(Required=false)]
        public int? MaxParallelism { get; set; }

        /// <summary>
        /// 最小并行度
        /// </summary>
        [NameInMap("MinParallelism")]
        [Validation(Required=false)]
        public int? MinParallelism { get; set; }

    }

}
