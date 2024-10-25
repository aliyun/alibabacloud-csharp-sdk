// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdIpv6InfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3703C4AC-9396-458C-8F25-1D701334D309</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>IPv6 support information.</para>
        /// </summary>
        [NameInMap("SupportIpv6Info")]
        [Validation(Required=false)]
        public DescribeEnsRegionIdIpv6InfoResponseBodySupportIpv6Info SupportIpv6Info { get; set; }
        public class DescribeEnsRegionIdIpv6InfoResponseBodySupportIpv6Info : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-xxxx-4</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>Specifies whether IPv6 is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportIpv6")]
            [Validation(Required=false)]
            public bool? SupportIpv6 { get; set; }

        }

    }

}
