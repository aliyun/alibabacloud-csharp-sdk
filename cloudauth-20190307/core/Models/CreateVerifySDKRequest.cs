// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateVerifySDKRequest : TeaModel {
        [NameInMap("AppUrl")]
        [Validation(Required=true)]
        public string AppUrl { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
