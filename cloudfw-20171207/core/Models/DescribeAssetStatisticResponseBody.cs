// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84******25g4d2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics on specifications.</para>
        /// </summary>
        [NameInMap("ResourceSpecStatistic")]
        [Validation(Required=false)]
        public DescribeAssetStatisticResponseBodyResourceSpecStatistic ResourceSpecStatistic { get; set; }
        public class DescribeAssetStatisticResponseBodyResourceSpecStatistic : TeaModel {
            /// <summary>
            /// <para>The number of public IP addresses that can be protected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IpNumSpec")]
            [Validation(Required=false)]
            public int? IpNumSpec { get; set; }

            /// <summary>
            /// <para>The number of public IP addresses that are protected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("IpNumUsed")]
            [Validation(Required=false)]
            public int? IpNumUsed { get; set; }

            /// <summary>
            /// <para>The number of public IP addresses that can enable data leakage detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SensitiveDataIpNumSpec")]
            [Validation(Required=false)]
            public long? SensitiveDataIpNumSpec { get; set; }

            /// <summary>
            /// <para>The number of public IP addresses that enabled data leakage detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SensitiveDataIpNumUsed")]
            [Validation(Required=false)]
            public long? SensitiveDataIpNumUsed { get; set; }

        }

    }

}
