// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Goodstech20191230.Models
{
    public class RecognizeFurnitureSpuAdvanceRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

        [NameInMap("XLength")]
        [Validation(Required=false)]
        public float? XLength { get; set; }

        [NameInMap("YLength")]
        [Validation(Required=false)]
        public float? YLength { get; set; }

        [NameInMap("ZLength")]
        [Validation(Required=false)]
        public float? ZLength { get; set; }

    }

}
