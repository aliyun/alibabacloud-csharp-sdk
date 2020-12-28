// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyVisualServicePasswdRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

        [NameInMap("RunasUserPassword")]
        [Validation(Required=false)]
        public string RunasUserPassword { get; set; }

        [NameInMap("Passwd")]
        [Validation(Required=false)]
        public string Passwd { get; set; }

    }

}
