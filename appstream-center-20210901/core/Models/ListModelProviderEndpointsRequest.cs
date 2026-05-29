// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelProviderEndpointsRequest : TeaModel {
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

    }

}
