// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHybridProxyListResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeHybridProxyListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeHybridProxyListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The information about the proxy clusters.</para>
        /// </summary>
        [NameInMap("ProxyList")]
        [Validation(Required=false)]
        public List<DescribeHybridProxyListResponseBodyProxyList> ProxyList { get; set; }
        public class DescribeHybridProxyListResponseBodyProxyList : TeaModel {
            /// <summary>
            /// <para>The number of servers that are connected to the proxy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ClientCount")]
            [Validation(Required=false)]
            public int? ClientCount { get; set; }

            /// <summary>
            /// <para>The version of the proxy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proxy_01_05</para>
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf61q03boqhhmeai1XXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.76.XXX.XXX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.23.XXX.XXX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The UUID of the proxy node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inet-proxy-3bb11fad-37d6-4aee-9c37-b0ad1612a18e</para>
            /// </summary>
            [NameInMap("ProxyUuid")]
            [Validation(Required=false)]
            public string ProxyUuid { get; set; }

            /// <summary>
            /// <para>The status of the proxy server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b></description></item>
            /// <item><description><b>offline</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The UUID of the server that is connected to the proxy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59a9d158-b2f0-4766-a893-ae67b943XXXX</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75801E5D-E2EB-5C1D-B65D-2F7D2B00EF93</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
