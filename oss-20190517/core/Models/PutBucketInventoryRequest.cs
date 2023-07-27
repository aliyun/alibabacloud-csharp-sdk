// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class PutBucketInventoryRequest : TeaModel {
        /// <summary>
        /// 存储清单配置信息的容器。
        /// </summary>
        [NameInMap("InventoryConfiguration")]
        [Validation(Required=false)]
        public InventoryConfiguration InventoryConfiguration { get; set; }

        [NameInMap("inventoryId")]
        [Validation(Required=false)]
        public string InventoryId { get; set; }

    }

}
