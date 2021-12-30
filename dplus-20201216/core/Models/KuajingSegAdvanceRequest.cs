// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class KuajingSegAdvanceRequest : TeaModel {
        [NameInMap("PicUrlObject")]
        [Validation(Required=true)]
        public Stream PicUrlObject { get; set; }

        [NameInMap("ReturnPicFormat")]
        [Validation(Required=false)]
        public string ReturnPicFormat { get; set; }

        [NameInMap("ReturnPicType")]
        [Validation(Required=false)]
        public string ReturnPicType { get; set; }

    }

}
