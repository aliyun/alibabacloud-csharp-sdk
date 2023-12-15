// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceIntegration : TeaModel {
        [NameInMap("datasourceAmount")]
        [Validation(Required=false)]
        public long? DatasourceAmount { get; set; }

        [NameInMap("integrationId")]
        [Validation(Required=false)]
        public string IntegrationId { get; set; }

        [NameInMap("integrationName")]
        [Validation(Required=false)]
        public string IntegrationName { get; set; }

        [NameInMap("previews")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceIntegrationPreview> Previews { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("supportRegions")]
        [Validation(Required=false)]
        public List<string> SupportRegions { get; set; }

    }

}
