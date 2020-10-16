// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class InvokeMotorModelRequest : TeaModel {
        [NameInMap("PicId")]
        [Validation(Required=true)]
        public string PicId { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=true)]
        public string CorpId { get; set; }

        [NameInMap("PicPath")]
        [Validation(Required=false)]
        public string PicPath { get; set; }

        [NameInMap("PicUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

    }

}
