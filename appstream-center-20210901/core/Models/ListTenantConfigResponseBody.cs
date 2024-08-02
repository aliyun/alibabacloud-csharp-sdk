// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListTenantConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TenantConfigModel")]
        [Validation(Required=false)]
        public ListTenantConfigResponseBodyTenantConfigModel TenantConfigModel { get; set; }
        public class ListTenantConfigResponseBodyTenantConfigModel : TeaModel {
            [NameInMap("AppInstanceGroupExpireRemind")]
            [Validation(Required=false)]
            public bool? AppInstanceGroupExpireRemind { get; set; }

        }

    }

}
