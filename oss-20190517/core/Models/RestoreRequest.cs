// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RestoreRequest : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public long? Days { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public RestoreRequestJobParameters JobParameters { get; set; }
        public class RestoreRequestJobParameters : TeaModel {
            [NameInMap("Tier")]
            [Validation(Required=false)]
            public string Tier { get; set; }
        };

    }

}
