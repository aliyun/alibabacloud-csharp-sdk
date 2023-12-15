// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateChannelRequest : TeaModel {
        [NameInMap("BatchTimeout")]
        [Validation(Required=false)]
        public int? BatchTimeout { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("MaxMessageCount")]
        [Validation(Required=false)]
        public int? MaxMessageCount { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public List<CreateChannelRequestOrganization> Organization { get; set; }
        public class CreateChannelRequestOrganization : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("PreferredMaxBytes")]
        [Validation(Required=false)]
        public int? PreferredMaxBytes { get; set; }

    }

}
