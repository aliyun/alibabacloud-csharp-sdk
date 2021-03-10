// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateProductTopicRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("Operation")]
        [Validation(Required=true)]
        public string Operation { get; set; }

        [NameInMap("TopicShortName")]
        [Validation(Required=true)]
        public string TopicShortName { get; set; }

        [NameInMap("TopicId")]
        [Validation(Required=true)]
        public string TopicId { get; set; }

    }

}
