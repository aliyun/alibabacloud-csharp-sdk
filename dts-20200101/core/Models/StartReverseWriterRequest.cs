// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StartReverseWriterRequest : TeaModel {
        [NameInMap("CheckPoint")]
        [Validation(Required=false)]
        public string CheckPoint { get; set; }

        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

    }

}
