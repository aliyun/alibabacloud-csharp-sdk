// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>The GWLB listeners.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>The description of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>listener-description</para>
            /// </summary>
            [NameInMap("ListenerDescription")]
            [Validation(Required=false)]
            public string ListenerDescription { get; set; }

            /// <summary>
            /// <para>The listener ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-vu7folhh5ntm8u****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The status of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Provisioning</b>: The listener is being created.</description></item>
            /// <item><description><b>Running</b>: The listener is running.</description></item>
            /// <item><description><b>Configuring</b>: The listener is being configured.</description></item>
            /// <item><description><b>Deleting</b>: The listener is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            /// <summary>
            /// <para>The GWLB instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gwlb-uf6hbeh795xlqln7g****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The server group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-5yapcb422i51ru****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersTags> Tags { get; set; }
            public class ListListenersResponseBodyListenersTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The timeout period of an idle TCP connection. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>350</para>
            /// </summary>
            [NameInMap("TcpIdleTimeout")]
            [Validation(Required=false)]
            public int? TcpIdleTimeout { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to be returned from a single query when the NextToken parameter is used in the query. Valid values: 1 to 1000. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5c281c0a0d6bfb6355ed088c2108aca8e0b5e8707e68****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7DBFC67C-A272-5952-8287-6C3EBE4E04D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
