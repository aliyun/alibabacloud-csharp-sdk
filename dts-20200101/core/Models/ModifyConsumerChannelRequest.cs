// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyConsumerChannelRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("ConsumerGroupId")]
        [Validation(Required=false)]
        public string ConsumerGroupId { get; set; }

        [NameInMap("ConsumerGroupPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupPassword { get; set; }

        [NameInMap("ConsumerGroupUserName")]
        [Validation(Required=false)]
        public string ConsumerGroupUserName { get; set; }

        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

    }

}
