// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CopyCasterRequest : TeaModel {
        [NameInMap("CasterName")]
        [Validation(Required=true)]
        public string CasterName { get; set; }

        [NameInMap("SrcCasterId")]
        [Validation(Required=true)]
        public string SrcCasterId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

    }

}
