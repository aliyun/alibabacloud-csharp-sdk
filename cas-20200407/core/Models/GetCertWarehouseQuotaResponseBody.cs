// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCertWarehouseQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The total quota for the certificate application service. This includes both complimentary and purchased quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("AppTotalQuota")]
        [Validation(Required=false)]
        public long? AppTotalQuota { get; set; }

        /// <summary>
        /// <para>The used quota for the certificate application service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("AppUseCount")]
        [Validation(Required=false)]
        public long? AppUseCount { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates this unique ID for each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total quota for the electronic contract signing service. This includes both complimentary and purchased quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public long? TotalQuota { get; set; }

        /// <summary>
        /// <para>The used quota for the electronic contract signing service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public long? UseCount { get; set; }

    }

}
