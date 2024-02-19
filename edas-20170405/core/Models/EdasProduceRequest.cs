/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170405.Models
{
    public class EdasProduceRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("sourceFlag")]
        [Validation(Required=false)]
        public string SourceFlag { get; set; }

    }

}
