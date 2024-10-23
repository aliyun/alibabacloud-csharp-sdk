// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ConcurrencyConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:123:functions/demo</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("reservedConcurrency")]
        [Validation(Required=false)]
        public long? ReservedConcurrency { get; set; }

    }

}
