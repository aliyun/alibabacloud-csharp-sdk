// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FindContainerNetworkConnectResponseBody : TeaModel {
        /// <summary>
        /// <para>The network connectivity information.</para>
        /// </summary>
        [NameInMap("Connects")]
        [Validation(Required=false)]
        public List<FindContainerNetworkConnectResponseBodyConnects> Connects { get; set; }
        public class FindContainerNetworkConnectResponseBodyConnects : TeaModel {
            /// <summary>
            /// <para>The destination container information.</para>
            /// <remarks>
            /// <para>Notice: This parameter is not supported..</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DstContainer")]
            [Validation(Required=false)]
            public FindContainerNetworkConnectResponseBodyConnectsDstContainer DstContainer { get; set; }
            public class FindContainerNetworkConnectResponseBodyConnectsDstContainer : TeaModel {
                /// <summary>
                /// <para>The container ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48a6dxxx9d5a5866</para>
                /// </summary>
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

            }

            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.20.62.176</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// <para>The timestamp when the connection first occurred. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636077279174</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The network connectivity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1458</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The timestamp when the connection most recently occurred. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636595679174</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The source container information.</para>
            /// <remarks>
            /// <para>Notice: This parameter is not supported..</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SrcContainer")]
            [Validation(Required=false)]
            public FindContainerNetworkConnectResponseBodyConnectsSrcContainer SrcContainer { get; set; }
            public class FindContainerNetworkConnectResponseBodyConnectsSrcContainer : TeaModel {
                /// <summary>
                /// <para>The container ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48a6xxx5709d5a5866</para>
                /// </summary>
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

            }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35.233.62.116</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <para>The source port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public string SrcPort { get; set; }

        }

        /// <summary>
        /// <para>The paging information for the query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public FindContainerNetworkConnectResponseBodyPageInfo PageInfo { get; set; }
        public class FindContainerNetworkConnectResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page in the paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The current page number in the paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page in the paging query. Default value: <b>20</b>, which indicates that 20 network connectivity entries are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of connections returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8686CE6E-9BFA-5436-A9D9-77B984AEE7F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
