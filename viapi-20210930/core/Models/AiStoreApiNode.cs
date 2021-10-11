// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class AiStoreApiNode : TeaModel {
        /// <summary>
        /// 产品名称
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [NameInMap("ProductDesc")]
        [Validation(Required=false)]
        public string ProductDesc { get; set; }

        /// <summary>
        /// API列表
        /// </summary>
        [NameInMap("Apis")]
        [Validation(Required=false)]
        public List<AiStoreUserTask> Apis { get; set; }

    }

}
