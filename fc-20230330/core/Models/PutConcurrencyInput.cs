// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutConcurrencyInput : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("reservedConcurrency")]
        [Validation(Required=false)]
        public long? ReservedConcurrency { get; set; }

    }

}
