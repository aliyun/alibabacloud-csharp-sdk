// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MaxComputeExportConfigurationSink : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("odpsEndpoint")]
        [Validation(Required=false)]
        public string OdpsEndpoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("odpsProject")]
        [Validation(Required=false)]
        public string OdpsProject { get; set; }

        [NameInMap("odpsRolearn")]
        [Validation(Required=false)]
        public string OdpsRolearn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("odpsTable")]
        [Validation(Required=false)]
        public string OdpsTable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("odpsTunnelEndpoint")]
        [Validation(Required=false)]
        public string OdpsTunnelEndpoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("partitionColumn")]
        [Validation(Required=false)]
        public List<string> PartitionColumn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("partitionTimeFormat")]
        [Validation(Required=false)]
        public string PartitionTimeFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
