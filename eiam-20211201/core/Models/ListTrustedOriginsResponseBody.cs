// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListTrustedOriginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page that takes effect for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NT_example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-example</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of trusted origins.</para>
        /// </summary>
        [NameInMap("TrustedOrigins")]
        [Validation(Required=false)]
        public List<ListTrustedOriginsResponseBodyTrustedOrigins> TrustedOrigins { get; set; }
        public class ListTrustedOriginsResponseBodyTrustedOrigins : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-20T08:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_example</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The browser origin.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://console.qoder.com">https://console.qoder.com</a></para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The trusted origin name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qoder Production Console</para>
            /// </summary>
            [NameInMap("TrustOriginName")]
            [Validation(Required=false)]
            public string TrustOriginName { get; set; }

            /// <summary>
            /// <para>The trusted origin ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>to_example</para>
            /// </summary>
            [NameInMap("TrustedOriginId")]
            [Validation(Required=false)]
            public string TrustedOriginId { get; set; }

            /// <summary>
            /// <para>The trusted origin scene.</para>
            /// </summary>
            [NameInMap("TrustedOriginScene")]
            [Validation(Required=false)]
            public List<string> TrustedOriginScene { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-20T08:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
