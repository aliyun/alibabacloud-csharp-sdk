// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class FaceTidyupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FaceTidyupResponseBodyData Data { get; set; }
        public class FaceTidyupResponseBodyData : TeaModel {
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
