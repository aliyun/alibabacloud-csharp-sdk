// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceNetExpireTimeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NetInfoItems")]
        [Validation(Required=false)]
        public ModifyInstanceNetExpireTimeResponseBodyNetInfoItems NetInfoItems { get; set; }
        public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItems : TeaModel {
            [NameInMap("NetInfoItem")]
            [Validation(Required=false)]
            public List<ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem> NetInfoItem { get; set; }
            public class ModifyInstanceNetExpireTimeResponseBodyNetInfoItemsNetInfoItem : TeaModel {
                public string DBInstanceNetType { get; set; }
                public string Port { get; set; }
                public string ExpiredTime { get; set; }
                public string ConnectionString { get; set; }
                public string IPAddress { get; set; }
            }
        };

    }

}
