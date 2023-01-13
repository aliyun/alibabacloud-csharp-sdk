// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListParserDestinationRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("IsFailover")]
        [Validation(Required=false)]
        public bool? IsFailover { get; set; }

        [NameInMap("ParserId")]
        [Validation(Required=true)]
        public long? ParserId { get; set; }

    }

}
