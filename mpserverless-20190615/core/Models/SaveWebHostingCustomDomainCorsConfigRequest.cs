// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class SaveWebHostingCustomDomainCorsConfigRequest : TeaModel {
        [NameInMap("AccessControlAllowOrigin")]
        [Validation(Required=false)]
        public string AccessControlAllowOrigin { get; set; }

        [NameInMap("AccessOriginControl")]
        [Validation(Required=false)]
        public bool? AccessOriginControl { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EnableCors")]
        [Validation(Required=false)]
        public bool? EnableCors { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
