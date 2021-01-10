// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMqSofamqRouterRequest : TeaModel {
        [NameInMap("DestinationCell")]
        [Validation(Required=false)]
        public string DestinationCell { get; set; }

        [NameInMap("DestinationInstanceId")]
        [Validation(Required=false)]
        public string DestinationInstanceId { get; set; }

        [NameInMap("DestinationTopic")]
        [Validation(Required=false)]
        public string DestinationTopic { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SourceCell")]
        [Validation(Required=false)]
        public string SourceCell { get; set; }

        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        [NameInMap("SourceTopic")]
        [Validation(Required=false)]
        public string SourceTopic { get; set; }

    }

}
