// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetIntegrationConfigRequest : TeaModel {
        /// <summary>
        /// 集成配置id
        /// </summary>
        [NameInMap("integrationConfigId")]
        [Validation(Required=false)]
        public long? IntegrationConfigId { get; set; }

        /// <summary>
        /// 幂等id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
