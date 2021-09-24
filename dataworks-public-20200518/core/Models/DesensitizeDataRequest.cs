// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DesensitizeDataRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=true)]
        public string Data { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=true)]
        public string SceneCode { get; set; }

    }

}
