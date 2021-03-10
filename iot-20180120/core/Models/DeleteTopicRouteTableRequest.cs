// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeleteTopicRouteTableRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("DstTopic")]
        [Validation(Required=true)]
        public List<string> DstTopic { get; set; }

        [NameInMap("SrcTopic")]
        [Validation(Required=true)]
        public string SrcTopic { get; set; }

    }

}
