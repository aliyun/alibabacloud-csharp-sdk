// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class OpenApiQueryActiveSceneRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("MpaasMqcpOpenApiQueryActiveSceneReqJsonStr")]
        [Validation(Required=false)]
        public string MpaasMqcpOpenApiQueryActiveSceneReqJsonStr { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
