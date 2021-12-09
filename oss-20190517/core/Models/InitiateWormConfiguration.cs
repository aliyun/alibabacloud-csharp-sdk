// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InitiateWormConfiguration : TeaModel {
        /// <summary>
        /// The number of days for which objects can be retained
        /// </summary>
        [NameInMap("RetentionPeriodInDays")]
        [Validation(Required=false)]
        public int? RetentionPeriodInDays { get; set; }

    }

}
