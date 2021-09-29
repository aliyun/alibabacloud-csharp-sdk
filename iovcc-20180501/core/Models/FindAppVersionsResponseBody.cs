// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindAppVersionsResponseBody : TeaModel {
        [NameInMap("AppVersionList")]
        [Validation(Required=false)]
        public FindAppVersionsResponseBodyAppVersionList AppVersionList { get; set; }
        public class FindAppVersionsResponseBodyAppVersionList : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindAppVersionsResponseBodyAppVersionListItems> Items { get; set; }
            public class FindAppVersionsResponseBodyAppVersionListItems : TeaModel {
                public string Status { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public string GmtModify { get; set; }
                public string IsAllowNewInstall { get; set; }
                public string StatusName { get; set; }
                public string RestartAppParam { get; set; }
                public string IsSilentUpgrade { get; set; }
                public string AppPackageName { get; set; }
                public long? GmtModifyTimestamp { get; set; }
                public string AppName { get; set; }
                public string InstallType { get; set; }
                public string IsNeedRestart { get; set; }
                public string RestartAppType { get; set; }
                public string AppId { get; set; }
                public string RestartType { get; set; }
                public string GmtCreate { get; set; }
                public string AppVersion { get; set; }
                public string VersionCode { get; set; }
                public string IsForceUpgrade { get; set; }
                public long? Id { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
