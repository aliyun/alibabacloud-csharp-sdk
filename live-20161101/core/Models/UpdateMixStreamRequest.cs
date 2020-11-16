// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateMixStreamRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("MixStreamId")]
        [Validation(Required=true)]
        public string MixStreamId { get; set; }

        [NameInMap("InputStreamList")]
        [Validation(Required=true)]
        public string InputStreamList { get; set; }

        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

    }

}
