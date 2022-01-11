// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEngineVersionResponseBody : TeaModel {
        [NameInMap("DBVersionRelease")]
        [Validation(Required=false)]
        public string DBVersionRelease { get; set; }

        [NameInMap("EnableUpgradeMajorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMajorVersion { get; set; }

        [NameInMap("EnableUpgradeMinorVersion")]
        [Validation(Required=false)]
        public bool? EnableUpgradeMinorVersion { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public string MajorVersion { get; set; }

        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        [NameInMap("ProxyMinorVersion")]
        [Validation(Required=false)]
        public string ProxyMinorVersion { get; set; }

        [NameInMap("ProxyVersionRelease")]
        [Validation(Required=false)]
        public string ProxyVersionRelease { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
