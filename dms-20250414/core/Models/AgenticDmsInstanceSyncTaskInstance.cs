// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDmsInstanceSyncTaskInstance : TeaModel {
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        [NameInMap("CrawlerTaskId")]
        [Validation(Required=false)]
        public string CrawlerTaskId { get; set; }

        [NameInMap("DatasourceUuid")]
        [Validation(Required=false)]
        public string DatasourceUuid { get; set; }

        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("DmsInstanceId")]
        [Validation(Required=false)]
        public string DmsInstanceId { get; set; }

        [NameInMap("DmsInstanceSummary")]
        [Validation(Required=false)]
        public AgenticDmsInstanceSyncTaskInstanceDmsInstanceSummary DmsInstanceSummary { get; set; }
        public class AgenticDmsInstanceSyncTaskInstanceDmsInstanceSummary : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("InstanceResourceId")]
            [Validation(Required=false)]
            public string InstanceResourceId { get; set; }

            [NameInMap("InstanceSource")]
            [Validation(Required=false)]
            public string InstanceSource { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("DmsRegionId")]
        [Validation(Required=false)]
        public string DmsRegionId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorSummary")]
        [Validation(Required=false)]
        public string ErrorSummary { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
