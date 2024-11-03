// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchDescribeCdnIpInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The results about IP addresses returned.</para>
        /// </summary>
        [NameInMap("IpInfoList")]
        [Validation(Required=false)]
        public List<BatchDescribeCdnIpInfoResponseBodyIpInfoList> IpInfoList { get; set; }
        public class BatchDescribeCdnIpInfoResponseBodyIpInfoList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the IP address belongs to an Alibaba Cloud CDN point of presence (POP).</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CdnIp")]
            [Validation(Required=false)]
            public string CdnIp { get; set; }

            /// <summary>
            /// <para>The city to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The country to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111.XXX.XXX.230</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The ISP to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Move</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>The province to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55ADD936-763F-5E1A-BF54-2EA3F6E94A52</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
