// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class ReplaceMigrationAvailableNumbersRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("OperatorUid")]
        [Validation(Required=false)]
        public long? OperatorUid { get; set; }

        [NameInMap("V1Numbers")]
        [Validation(Required=false)]
        public string V1Numbers { get; set; }

        [NameInMap("V2Numbers")]
        [Validation(Required=false)]
        public string V2Numbers { get; set; }

    }

}
