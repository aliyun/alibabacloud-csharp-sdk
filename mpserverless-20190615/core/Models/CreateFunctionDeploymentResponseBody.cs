// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class CreateFunctionDeploymentResponseBody : TeaModel {
        [NameInMap("DeploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadSignedUrl")]
        [Validation(Required=false)]
        public string UploadSignedUrl { get; set; }

    }

}
