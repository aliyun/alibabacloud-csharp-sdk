// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SyncLinkefabricFabricMsgcloudconfigthroughdevstageRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("FromDevStage")]
        [Validation(Required=false)]
        public string FromDevStage { get; set; }

        [NameInMap("FromEnv")]
        [Validation(Required=false)]
        public string FromEnv { get; set; }

        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        [NameInMap("OriginAppName")]
        [Validation(Required=false)]
        public string OriginAppName { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("ToDevStage")]
        [Validation(Required=false)]
        public string ToDevStage { get; set; }

        [NameInMap("ToEnv")]
        [Validation(Required=false)]
        public string ToEnv { get; set; }

    }

}
