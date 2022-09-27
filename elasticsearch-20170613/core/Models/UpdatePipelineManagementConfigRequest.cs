// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePipelineManagementConfigRequest : TeaModel {
        [NameInMap("endpoints")]
        [Validation(Required=false)]
        public List<string> Endpoints { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("pipelineIds")]
        [Validation(Required=false)]
        public List<string> PipelineIds { get; set; }

        [NameInMap("pipelineManagementType")]
        [Validation(Required=false)]
        public string PipelineManagementType { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
