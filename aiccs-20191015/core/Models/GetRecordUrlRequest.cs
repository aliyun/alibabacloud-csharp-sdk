// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetRecordUrlRequest : TeaModel {
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

    }

}
