// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class RebootDesktopsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=true)]
        public string ClientId { get; set; }

        [NameInMap("LoginToken")]
        [Validation(Required=true)]
        public string LoginToken { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=true)]
        public List<string> DesktopId { get; set; }

    }

}
