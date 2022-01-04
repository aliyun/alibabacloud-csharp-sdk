// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class VerifyBankElementRequest : TeaModel {
        [NameInMap("BankCardFile")]
        [Validation(Required=false)]
        public string BankCardFile { get; set; }

        [NameInMap("BankCardNo")]
        [Validation(Required=false)]
        public string BankCardNo { get; set; }

        [NameInMap("BankCardUrl")]
        [Validation(Required=false)]
        public string BankCardUrl { get; set; }

        [NameInMap("IdName")]
        [Validation(Required=false)]
        public string IdName { get; set; }

        [NameInMap("IdNo")]
        [Validation(Required=false)]
        public string IdNo { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
