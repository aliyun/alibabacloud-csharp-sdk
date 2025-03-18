// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>The listeners of the ELB instance.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public DescribeLoadBalancerListenersResponseBodyListeners Listeners { get; set; }
        public class DescribeLoadBalancerListenersResponseBodyListeners : TeaModel {
            [NameInMap("Listener")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerListenersResponseBodyListenersListener> Listener { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersListener : TeaModel {
                [NameInMap("BackendServerPort")]
                [Validation(Required=false)]
                public int? BackendServerPort { get; set; }

                /// <summary>
                /// <para>The timestamp when the listener was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-15T08:42:57Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The listener port that is used for HTTP-to-HTTPS redirection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("ForwardPort")]
                [Validation(Required=false)]
                public string ForwardPort { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTP-to-HTTPS redirection is enabled for the listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("ListenerForward")]
                [Validation(Required=false)]
                public string ListenerForward { get; set; }

                /// <summary>
                /// <para>The listening port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public string ListenerPort { get; set; }

                /// <summary>
                /// <para>The ID of the ELB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-51a5fhou****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The network transmission protocol that is used by the listener.</para>
                /// <list type="bullet">
                /// <item><description><b>tcp</b></description></item>
                /// <item><description><b>udp</b></description></item>
                /// <item><description><b>http</b></description></item>
                /// <item><description><b>https</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The status of the listener. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>running</b></description></item>
                /// <item><description><b>stopped</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3B261DD-3858-4D3C-877D-303ADF374600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
