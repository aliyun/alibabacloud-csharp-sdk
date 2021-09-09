// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateWhitelistRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=true)]
        public string BizId { get; set; }

        [NameInMap("IdCardNum")]
        [Validation(Required=true)]
        public string IdCardNum { get; set; }

        [NameInMap("ValidDay")]
        [Validation(Required=true)]
        public string ValidDay { get; set; }

    }

}
