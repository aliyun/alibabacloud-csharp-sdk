// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class UpdateFaceConfigRequest : TeaModel {
        [NameInMap("BizName")]
        [Validation(Required=true)]
        public string BizName { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=true)]
        public string BizType { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
