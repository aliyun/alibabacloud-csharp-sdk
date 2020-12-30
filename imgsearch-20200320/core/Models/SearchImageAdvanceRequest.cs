// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class SearchImageAdvanceRequest : TeaModel {
        [NameInMap("ImageUrlObject")]
        [Validation(Required=true)]
        public Stream ImageUrlObject { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

    }

}
