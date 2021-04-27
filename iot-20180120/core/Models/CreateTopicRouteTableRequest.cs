// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateTopicRouteTableRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("DstTopic")]
        [Validation(Required=false)]
        public List<string> DstTopic { get; set; }

        [NameInMap("SrcTopic")]
        [Validation(Required=false)]
        public string SrcTopic { get; set; }

    }

}
