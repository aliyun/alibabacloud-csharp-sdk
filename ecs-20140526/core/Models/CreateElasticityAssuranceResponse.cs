// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateElasticityAssuranceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PrivatePoolOptionsId")]
        [Validation(Required=true)]
        public string PrivatePoolOptionsId { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=true)]
        public string OrderId { get; set; }

    }

}
