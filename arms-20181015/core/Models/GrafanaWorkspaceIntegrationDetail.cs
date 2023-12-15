// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceIntegrationDetail : TeaModel {
        [NameInMap("dataSources")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceIntegrationDataSource> DataSources { get; set; }

        [NameInMap("integrationId")]
        [Validation(Required=false)]
        public string IntegrationId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
