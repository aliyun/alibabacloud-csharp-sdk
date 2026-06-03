// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetAuditCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E6A08A8A-F962-4FAD-AF0C-86B393E1F9C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RiskCount")]
        [Validation(Required=false)]
        public long? RiskCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SessionCount")]
        [Validation(Required=false)]
        public long? SessionCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("SqlCount")]
        [Validation(Required=false)]
        public long? SqlCount { get; set; }

    }

}
