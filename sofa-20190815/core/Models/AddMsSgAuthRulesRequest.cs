// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsSgAuthRulesRequest : TeaModel {
        [NameInMap("AuthGroupId")]
        [Validation(Required=false)]
        public long? AuthGroupId { get; set; }

        [NameInMap("AuthRule")]
        [Validation(Required=false)]
        public string AuthRule { get; set; }

        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
