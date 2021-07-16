// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIntegrationConfigTimelinesRequest : TeaModel {
        /// <summary>
        /// 集成配置id
        /// </summary>
        [NameInMap("integrationConfigId")]
        [Validation(Required=false)]
        public long? IntegrationConfigId { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
