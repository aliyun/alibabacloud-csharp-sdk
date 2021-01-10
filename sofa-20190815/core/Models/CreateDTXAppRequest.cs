// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDTXAppRequest : TeaModel {
        [NameInMap("ActivityMode")]
        [Validation(Required=false)]
        public long? ActivityMode { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SplitRuleJsonStr")]
        [Validation(Required=false)]
        public string SplitRuleJsonStr { get; set; }

    }

}
