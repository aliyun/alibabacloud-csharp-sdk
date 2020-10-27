// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAttachmentAttributesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyInstanceAttachmentAttributesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyInstanceAttachmentAttributesRequestPrivatePoolOptions : TeaModel {
            [NameInMap("MatchCriteria")]
            [Validation(Required=true)]
            public string MatchCriteria { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

    }

}
