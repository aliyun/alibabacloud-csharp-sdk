// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class CreateMcubeUpgradePackageRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("AppstoreUrl")]
        [Validation(Required=false)]
        public string AppstoreUrl { get; set; }

        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("CustomDomainName")]
        [Validation(Required=false)]
        public string CustomDomainName { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("IconFileUrl")]
        [Validation(Required=false)]
        public string IconFileUrl { get; set; }

        [NameInMap("InstallAmount")]
        [Validation(Required=false)]
        public int? InstallAmount { get; set; }

        [NameInMap("IosSymbolfileUrl")]
        [Validation(Required=false)]
        public string IosSymbolfileUrl { get; set; }

        [NameInMap("IsEnterprise")]
        [Validation(Required=false)]
        public int? IsEnterprise { get; set; }

        [NameInMap("NeedCheck")]
        [Validation(Required=false)]
        public int? NeedCheck { get; set; }

        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ValidDays")]
        [Validation(Required=false)]
        public int? ValidDays { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
