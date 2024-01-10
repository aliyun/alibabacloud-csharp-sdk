// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeleteUserDefineTableDataByPrimaryKeyShrinkRequest : TeaModel {
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string ConditionsShrink { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("TableIdentifier")]
        [Validation(Required=false)]
        public string TableIdentifier { get; set; }

    }

}
