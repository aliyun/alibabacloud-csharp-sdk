// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckResultRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the check items.</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        [NameInMap("TaskSource")]
        [Validation(Required=false)]
        public string TaskSource { get; set; }

    }

}
