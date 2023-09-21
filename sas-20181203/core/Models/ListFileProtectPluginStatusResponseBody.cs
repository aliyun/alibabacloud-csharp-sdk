// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectPluginStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFileProtectPluginStatusResponseBodyData> Data { get; set; }
        public class ListFileProtectPluginStatusResponseBodyData : TeaModel {
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            [NameInMap("InstallCode")]
            [Validation(Required=false)]
            public string InstallCode { get; set; }

            [NameInMap("InstallMessage")]
            [Validation(Required=false)]
            public string InstallMessage { get; set; }

            [NameInMap("Installed")]
            [Validation(Required=false)]
            public bool? Installed { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("SupportFile")]
            [Validation(Required=false)]
            public bool? SupportFile { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectPluginStatusResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectPluginStatusResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
