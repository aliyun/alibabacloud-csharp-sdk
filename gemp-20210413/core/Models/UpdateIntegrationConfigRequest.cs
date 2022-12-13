// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateIntegrationConfigRequest : TeaModel {
        /// <summary>
        /// accessKey
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("integrationConfigId")]
        [Validation(Required=false)]
        public long? IntegrationConfigId { get; set; }

    }

}
