/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class CreateTextFileRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("TextFileName")]
        [Validation(Required=false)]
        public string TextFileName { get; set; }

        [NameInMap("TextFileUrl")]
        [Validation(Required=false)]
        public string TextFileUrl { get; set; }

    }

}
