// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateTaskRequest : TeaModel {
        [NameInMap("ClientFileName")]
        [Validation(Required=false)]
        public string ClientFileName { get; set; }

        [NameInMap("ClientPath")]
        [Validation(Required=false)]
        public string ClientPath { get; set; }

        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

    }

}
