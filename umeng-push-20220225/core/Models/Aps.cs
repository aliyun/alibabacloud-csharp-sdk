// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class Aps : TeaModel {
        [NameInMap("alert")]
        [Validation(Required=false)]
        public Alert Alert { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>+1(自增)，-1(自减)，4(设置数字)</para>
        /// </summary>
        [NameInMap("badge")]
        [Validation(Required=false)]
        public string Badge { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("contentAvailable")]
        [Validation(Required=false)]
        public int? ContentAvailable { get; set; }

        [NameInMap("interruptionLevel")]
        [Validation(Required=false)]
        public string InterruptionLevel { get; set; }

        [NameInMap("sound")]
        [Validation(Required=false)]
        public string Sound { get; set; }

        [NameInMap("threadID")]
        [Validation(Required=false)]
        public string ThreadID { get; set; }

    }

}
