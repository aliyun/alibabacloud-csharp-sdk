// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectKitchenAnimalsAdvanceRequest : TeaModel {
        [NameInMap("ImageURLAObject")]
        [Validation(Required=true)]
        public Stream ImageURLAObject { get; set; }

        [NameInMap("ImageURLB")]
        [Validation(Required=false)]
        public string ImageURLB { get; set; }

    }

}
