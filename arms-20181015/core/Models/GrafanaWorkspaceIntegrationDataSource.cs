// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceIntegrationDataSource : TeaModel {
        [NameInMap("clusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("datasourceId")]
        [Validation(Required=false)]
        public string DatasourceId { get; set; }

        [NameInMap("datasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        [NameInMap("datasourceUrl")]
        [Validation(Required=false)]
        public string DatasourceUrl { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("exploreUrl")]
        [Validation(Required=false)]
        public string ExploreUrl { get; set; }

        [NameInMap("folderUrl")]
        [Validation(Required=false)]
        public string FolderUrl { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
