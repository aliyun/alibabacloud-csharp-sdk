// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ChannelAssemblySourceLocation : TeaModel {
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("BaseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("SegmentDeliveryConfigurations")]
        [Validation(Required=false)]
        public string SegmentDeliveryConfigurations { get; set; }

        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
