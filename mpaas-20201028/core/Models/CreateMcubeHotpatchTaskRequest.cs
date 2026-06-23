// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateMcubeHotpatchTaskRequest : TeaModel {
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
        public long? GreyNum { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PackageId")]
        [Validation(Required=false)]
        public long? PackageId { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("PublishMode")]
        [Validation(Required=false)]
        public long? PublishMode { get; set; }

        [NameInMap("PublishType")]
        [Validation(Required=false)]
        public long? PublishType { get; set; }

        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WhitelistIds")]
        [Validation(Required=false)]
        public string WhitelistIds { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
