// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHybridProxyClusterListResponseBody : TeaModel {
        /// <summary>
        /// <para>The proxy clusters.</para>
        /// </summary>
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public List<DescribeHybridProxyClusterListResponseBodyClusterList> ClusterList { get; set; }
        public class DescribeHybridProxyClusterListResponseBodyClusterList : TeaModel {
            /// <summary>
            /// <para>The ID of the credential that is used for cluster authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            /// <summary>
            /// <para>The key of the credential that is used for cluster authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AuthKeySecret")]
            [Validation(Required=false)]
            public string AuthKeySecret { get; set; }

            /// <summary>
            /// <para>The number of servers that are connected to the proxy cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ClientCount")]
            [Validation(Required=false)]
            public int? ClientCount { get; set; }

            /// <summary>
            /// <para>The name of the proxy cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idc-sas-proxy</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The installation command for the node of the proxy cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstallCommand")]
            [Validation(Required=false)]
            public string InstallCommand { get; set; }

            /// <summary>
            /// <para>The endpoint of the cluster. An IP address or a domain name is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114.115.XXX.XXX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The timestamp when the cluster last sent a heartbeat message. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608304654000</para>
            /// </summary>
            [NameInMap("LastHeartTime")]
            [Validation(Required=false)]
            public long? LastHeartTime { get; set; }

            /// <summary>
            /// <para>The number of proxy nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProxyCount")]
            [Validation(Required=false)]
            public int? ProxyCount { get; set; }

            /// <summary>
            /// <para>The description of the proxy cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>offline</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeHybridProxyClusterListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeHybridProxyClusterListResponseBodyPageInfo : TeaModel {
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
            /// <para>45</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1A36413-50B2-5B2F-843F-EB14C582713F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
