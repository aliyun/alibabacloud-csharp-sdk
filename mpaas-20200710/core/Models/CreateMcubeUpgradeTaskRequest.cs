// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class CreateMcubeUpgradeTaskRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("GreyConfigInfo")]
        [Validation(Required=false)]
        public string GreyConfigInfo { get; set; }

        [NameInMap("GreyEndtimeData")]
        [Validation(Required=false)]
        public string GreyEndtimeData { get; set; }

        [NameInMap("GreyNum")]
        [Validation(Required=false)]
        public int? GreyNum { get; set; }

        [NameInMap("HistoryForce")]
        [Validation(Required=false)]
        public int? HistoryForce { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("PackageInfoId")]
        [Validation(Required=false)]
        public long? PackageInfoId { get; set; }

        [NameInMap("PublishMode")]
        [Validation(Required=false)]
        public int? PublishMode { get; set; }

        [NameInMap("PublishType")]
        [Validation(Required=false)]
        public int? PublishType { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UpgradeContent")]
        [Validation(Required=false)]
        public string UpgradeContent { get; set; }

        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public int? UpgradeType { get; set; }

        [NameInMap("WhitelistIds")]
        [Validation(Required=false)]
        public string WhitelistIds { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
