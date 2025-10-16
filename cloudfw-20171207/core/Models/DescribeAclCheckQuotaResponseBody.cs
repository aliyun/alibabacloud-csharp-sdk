// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclCheckQuotaResponseBody : TeaModel {
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public DescribeAclCheckQuotaResponseBodyQuota Quota { get; set; }
        public class DescribeAclCheckQuotaResponseBodyQuota : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("AvailableQuota")]
            [Validation(Required=false)]
            public long? AvailableQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("ConsumedQuota")]
            [Validation(Required=false)]
            public long? ConsumedQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1724982259</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7D5483BF-2262-586D-8706-BDDB8B42****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
