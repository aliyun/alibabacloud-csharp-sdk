// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aigen20240111.Models
{
    public class InteractiveFullSegmentationAdvanceRequest : TeaModel {
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public Stream ImageUrlObject { get; set; }

        [NameInMap("ReturnFormat")]
        [Validation(Required=false)]
        public string ReturnFormat { get; set; }

    }

}
