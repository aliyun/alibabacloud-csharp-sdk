// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMixStreamRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("LayoutId")]
        [Validation(Required=true)]
        public string LayoutId { get; set; }

        [NameInMap("InputStreamList")]
        [Validation(Required=true)]
        public string InputStreamList { get; set; }

        [NameInMap("OutputConfig")]
        [Validation(Required=true)]
        public string OutputConfig { get; set; }

        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public string CallbackConfig { get; set; }

    }

}
