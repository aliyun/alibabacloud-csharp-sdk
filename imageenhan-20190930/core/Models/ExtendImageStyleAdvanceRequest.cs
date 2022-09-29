// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class ExtendImageStyleAdvanceRequest : TeaModel {
        [NameInMap("MajorUrl")]
        [Validation(Required=false)]
        public Stream MajorUrlObject { get; set; }

        [NameInMap("StyleUrl")]
        [Validation(Required=false)]
        public Stream StyleUrlObject { get; set; }

    }

}
