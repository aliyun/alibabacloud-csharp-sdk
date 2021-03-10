// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeleteThingModelRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("PropertyIdentifier")]
        [Validation(Required=false)]
        public List<string> PropertyIdentifier { get; set; }

        [NameInMap("ServiceIdentifier")]
        [Validation(Required=false)]
        public List<string> ServiceIdentifier { get; set; }

        [NameInMap("EventIdentifier")]
        [Validation(Required=false)]
        public List<string> EventIdentifier { get; set; }

        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

    }

}
