// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7RsPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the parameters for back-to-origin processing.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<DescribeL7RsPolicyResponseBodyAttributes> Attributes { get; set; }
        public class DescribeL7RsPolicyResponseBodyAttributes : TeaModel {
            /// <summary>
            /// <para>The parameter for back-to-origin processing.</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public DescribeL7RsPolicyResponseBodyAttributesAttribute Attribute { get; set; }
            public class DescribeL7RsPolicyResponseBodyAttributesAttribute : TeaModel {
                /// <summary>
                /// <para>The timeout period for a new connection. Valid values: <b>1</b> to <b>10</b>. Unit: seconds. Default value: <b>5</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public int? ConnectTimeout { get; set; }

                /// <summary>
                /// <para>The expiration time of a connection, in seconds. If the number of failures at the origin server exceeds the <b>MaxFails</b> value, the address of the origin server is set to down and the expiration time is <b>FailTimeout</b>. The final value is the maximum value of <b>ConnectTimeout</b> and <b>FailTimeout</b>. Valid values: <b>1</b> to <b>3600</b>. Unit: seconds. Default value: <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FailTimeout")]
                [Validation(Required=false)]
                public int? FailTimeout { get; set; }

                /// <summary>
                /// <para>The maximum number of failures. This parameter is related to health check. Valid values: <b>1</b> to <b>10</b>. Unit: seconds. Default value: <b>3</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxFails")]
                [Validation(Required=false)]
                public int? MaxFails { get; set; }

                /// <summary>
                /// <para>The primary/secondary flag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>active</b>: primary</description></item>
                /// <item><description><b>backup</b>: secondary</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The timeout period for a read connection. Valid values: <b>10</b> to <b>300</b>. Unit: seconds. Default value: <b>120</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public int? ReadTimeout { get; set; }

                /// <summary>
                /// <para>The timeout period for a write connection. Valid values: <b>10</b> to <b>300</b>. Unit: seconds. Default value: <b>120</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("SendTimeout")]
                [Validation(Required=false)]
                public int? SendTimeout { get; set; }

                /// <summary>
                /// <para>The weight of the origin server. This parameter takes effect only when <b>ProxyMode</b> is set to <b>rr</b>.</para>
                /// <para>Valid values: <b>1</b> to <b>100</b>. Default value: <b>100</b>. A server with a higher weight receives more requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The address of the origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.<em><b>.</b></em>.1</para>
            /// </summary>
            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

            /// <summary>
            /// <para>The address type of the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: IP address</description></item>
            /// <item><description><b>1</b>: domain name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RsType")]
            [Validation(Required=false)]
            public int? RsType { get; set; }

        }

        /// <summary>
        /// <para>The scheduling algorithm for back-to-origin traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ip_hash</b>: the IP hash algorithm. This algorithm is used to redirect the requests from the same IP address to the same origin server.</description></item>
        /// <item><description><b>rr</b>: the round-robin algorithm. This algorithm is used to redirect requests to origin servers in turn.</description></item>
        /// <item><description><b>least_time</b>: the least response time algorithm. This algorithm is used to minimize the latency when requests are forwarded from Anti-DDoS Pro or Anti-DDoS Premium instances to origin servers based on the intelligent DNS resolution feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rr</para>
        /// </summary>
        [NameInMap("ProxyMode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E7F6B2C-03F2-462F-9076-B782CF0DD502</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("RsAttrRwTimeoutMax")]
        [Validation(Required=false)]
        public long? RsAttrRwTimeoutMax { get; set; }

        /// <summary>
        /// <para>The back-to-origin retry switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: on</description></item>
        /// <item><description><b>0</b>: off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UpstreamRetry")]
        [Validation(Required=false)]
        public int? UpstreamRetry { get; set; }

    }

}
