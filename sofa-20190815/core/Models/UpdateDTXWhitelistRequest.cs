// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateDTXWhitelistRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsElastic")]
        [Validation(Required=false)]
        public long? IsElastic { get; set; }

        [NameInMap("IsLoadTest")]
        [Validation(Required=false)]
        public long? IsLoadTest { get; set; }

        [NameInMap("LogicalDsName")]
        [Validation(Required=false)]
        public string LogicalDsName { get; set; }

    }

}
