// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListDemoCategoriesResponseBody : TeaModel {
        /// <summary>
        /// 样例列表
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<DemoCategory> Categories { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
