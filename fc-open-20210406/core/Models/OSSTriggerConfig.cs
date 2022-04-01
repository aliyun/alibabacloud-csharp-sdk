// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class OSSTriggerConfig : TeaModel {
        /// <summary>
        /// events
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public OSSTriggerFilter Filter { get; set; }

    }

}
