// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateCallTagsRequest : TeaModel {
        [NameInMap("CallTagNameList")]
        [Validation(Required=false)]
        public string CallTagNameList { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
