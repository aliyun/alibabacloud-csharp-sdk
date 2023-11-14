// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallHybridProxyRequest : TeaModel {
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("InstallCode")]
        [Validation(Required=false)]
        public string InstallCode { get; set; }

        [NameInMap("YundunUuids")]
        [Validation(Required=false)]
        public List<string> YundunUuids { get; set; }

    }

}
