// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetImageInfosRequest : TeaModel {
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIds { get; set; }

        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
