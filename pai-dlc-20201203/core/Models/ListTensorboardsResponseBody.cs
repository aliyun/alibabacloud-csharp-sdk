// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListTensorboardsResponseBody : TeaModel {
        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Tensorboard 列表
        /// </summary>
        [NameInMap("Tensorboards")]
        [Validation(Required=false)]
        public List<Tensorboard> Tensorboards { get; set; }

        /// <summary>
        /// 符合条件的数据源总数量
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
