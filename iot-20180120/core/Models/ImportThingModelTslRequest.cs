// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ImportThingModelTslRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("TslStr")]
        [Validation(Required=false)]
        public string TslStr { get; set; }

        [NameInMap("TslUrl")]
        [Validation(Required=false)]
        public string TslUrl { get; set; }

        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        [NameInMap("FunctionBlockName")]
        [Validation(Required=false)]
        public string FunctionBlockName { get; set; }

    }

}
