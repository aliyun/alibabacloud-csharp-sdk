// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryIpcQuotaResponseBody : TeaModel {
        [NameInMap("IpcQuotaInfos")]
        [Validation(Required=false)]
        public List<QueryIpcQuotaResponseBodyIpcQuotaInfos> IpcQuotaInfos { get; set; }
        public class QueryIpcQuotaResponseBodyIpcQuotaInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>understand</para>
            /// </summary>
            [NameInMap("Capability")]
            [Validation(Required=false)]
            public string Capability { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("ConsumedQuota")]
            [Validation(Required=false)]
            public long? ConsumedQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-21T16:00:00Z</para>
            /// </summary>
            [NameInMap("DateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxQuota")]
            [Validation(Required=false)]
            public long? MaxQuota { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
