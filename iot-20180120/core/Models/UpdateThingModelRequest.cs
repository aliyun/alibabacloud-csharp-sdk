// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateThingModelRequest : TeaModel {
        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        [NameInMap("FunctionBlockName")]
        [Validation(Required=false)]
        public string FunctionBlockName { get; set; }

        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ThingModelJson")]
        [Validation(Required=false)]
        public string ThingModelJson { get; set; }

    }

}
