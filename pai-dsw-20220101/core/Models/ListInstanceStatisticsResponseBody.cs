// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListInstanceStatisticsResponseBody : TeaModel {
        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 统计信息
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Statistics { get; set; }

    }

}
