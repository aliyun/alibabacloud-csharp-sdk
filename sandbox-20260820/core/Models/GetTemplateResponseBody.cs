// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class GetTemplateResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public PublicTemplateRuntimeConfig RuntimeConfig { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public PublicTemplateStatus Status { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
