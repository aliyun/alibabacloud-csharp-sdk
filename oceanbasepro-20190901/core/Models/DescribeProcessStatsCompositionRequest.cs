// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProcessStatsCompositionRequest : TeaModel {
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ServerIp")]
        [Validation(Required=false)]
        public string ServerIp { get; set; }

        [NameInMap("SqlText")]
        [Validation(Required=false)]
        public string SqlText { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UId")]
        [Validation(Required=false)]
        public string UId { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public string Users { get; set; }

    }

}
