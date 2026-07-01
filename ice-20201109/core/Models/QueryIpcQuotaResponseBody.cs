// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryIpcQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>List of IPC usage information.</para>
        /// </summary>
        [NameInMap("IpcQuotaInfos")]
        [Validation(Required=false)]
        public List<QueryIpcQuotaResponseBodyIpcQuotaInfos> IpcQuotaInfos { get; set; }
        public class QueryIpcQuotaResponseBodyIpcQuotaInfos : TeaModel {
            /// <summary>
            /// <para>Capability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>understand: understanding</para>
            /// </description></item>
            /// <item><description><para>understand-reid: understanding with reid</para>
            /// </description></item>
            /// <item><description><para>search: search</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>understand</para>
            /// </summary>
            [NameInMap("Capability")]
            [Validation(Required=false)]
            public string Capability { get; set; }

            /// <summary>
            /// <para>Consumed quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("ConsumedQuota")]
            [Validation(Required=false)]
            public long? ConsumedQuota { get; set; }

            /// <summary>
            /// <para>Corresponding time. UTC time in the format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-21T16:00:00Z</para>
            /// </summary>
            [NameInMap("DateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <para>Maximum available quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxQuota")]
            [Validation(Required=false)]
            public long? MaxQuota { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
