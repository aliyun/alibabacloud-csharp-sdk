// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateIntegrationConfigRequest : TeaModel {
        [NameInMap("monitorSourceId")]
        [Validation(Required=false)]
        public long? MonitorSourceId { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
