// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyDrdsIpWhiteListRequest : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public string IpWhiteList { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public bool? Mode { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("GroupAttribute")]
        [Validation(Required=false)]
        public string GroupAttribute { get; set; }

    }

}
