// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DirectNotifyReceiver : TeaModel {
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

        [NameInMap("identifiers")]
        [Validation(Required=false)]
        public List<string> Identifiers { get; set; }

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
