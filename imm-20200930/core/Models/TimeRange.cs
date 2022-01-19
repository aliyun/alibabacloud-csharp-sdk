// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TimeRange : TeaModel {
        /// <summary>
        /// end time
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public string End { get; set; }

        /// <summary>
        /// start time
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public string Start { get; set; }

    }

}
