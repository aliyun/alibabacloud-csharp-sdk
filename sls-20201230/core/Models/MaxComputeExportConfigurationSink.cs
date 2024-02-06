// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MaxComputeExportConfigurationSink : TeaModel {
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        [NameInMap("odpsAccessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessKeyId { get; set; }

        [NameInMap("odpsAccessSecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string OdpsAccessSecret { get; set; }

        [NameInMap("odpsEndpoint")]
        [Validation(Required=false)]
        public string OdpsEndpoint { get; set; }

        [NameInMap("odpsProject")]
        [Validation(Required=false)]
        public string OdpsProject { get; set; }

        [NameInMap("odpsRolearn")]
        [Validation(Required=false)]
        public string OdpsRolearn { get; set; }

        [NameInMap("odpsTable")]
        [Validation(Required=false)]
        public string OdpsTable { get; set; }

        [NameInMap("odpsTunnelEndpoint")]
        [Validation(Required=false)]
        public string OdpsTunnelEndpoint { get; set; }

        [NameInMap("partitionColumn")]
        [Validation(Required=false)]
        public List<string> PartitionColumn { get; set; }

        [NameInMap("partitionTimeFormat")]
        [Validation(Required=false)]
        public string PartitionTimeFormat { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
