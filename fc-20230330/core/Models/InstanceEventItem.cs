// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InstanceEventItem : TeaModel {
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<InstanceEventItem> Children { get; set; }

        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
