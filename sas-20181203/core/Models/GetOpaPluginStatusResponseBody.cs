// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaPluginStatusResponseBody : TeaModel {
        [NameInMap("InstallStatus")]
        [Validation(Required=false)]
        public List<GetOpaPluginStatusResponseBodyInstallStatus> InstallStatus { get; set; }
        public class GetOpaPluginStatusResponseBodyInstallStatus : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("InstallStatus")]
            [Validation(Required=false)]
            public bool? InstallStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
