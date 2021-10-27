// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyPolarDbReadWeightRequest : TeaModel {
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DbNodeIds")]
        [Validation(Required=false)]
        public string DbNodeIds { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("Weights")]
        [Validation(Required=false)]
        public string Weights { get; set; }

    }

}
