// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSubscriptionServiceGroupsRequest : TeaModel {
        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public List<long?> ServiceIds { get; set; }

    }

}
