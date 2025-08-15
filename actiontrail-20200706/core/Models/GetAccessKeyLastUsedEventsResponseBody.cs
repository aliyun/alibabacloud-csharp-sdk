// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned events.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<GetAccessKeyLastUsedEventsResponseBodyEvents> Events { get; set; }
        public class GetAccessKeyLastUsedEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>An array that consists of the details about the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;eventId&quot;: &quot;239EB588-CD24-522E-B0B5-174A1A58****&quot;,
            ///   &quot;eventVersion&quot;: 1,
            ///   &quot;eventSource&quot;: &quot;ecs.cn-hangzhou.aliyuncs.com&quot;,
            ///   &quot;sourceIpAddress&quot;: &quot;<c>10.10.**.**</c>&quot;,
            ///   &quot;eventType&quot;: &quot;ApiCall&quot;,
            ///   &quot;userIdentity&quot;: {
            ///     &quot;accountId&quot;: &quot;104758519118****&quot;,
            ///     &quot;principalId&quot;: &quot;24549429003625****&quot;,
            ///     &quot;type&quot;: &quot;ram-user&quot;,
            ///     &quot;userName&quot;: &quot;alice&quot;
            ///   },
            ///   &quot;serviceName&quot;: &quot;Ecs&quot;,
            ///   &quot;apiVersion&quot;: &quot;2016-01-20&quot;,
            ///   &quot;requestId&quot;: &quot;239EB588-CD24-522E-B0B5-174A1A588BE0&quot;,
            ///   &quot;eventTime&quot;: &quot;2021-08-05T09:21:32Z&quot;,
            ///   &quot;isGlobal&quot;: false,
            ///   &quot;acsRegion&quot;: &quot;cn-hangzhou&quot;,
            ///   &quot;eventName&quot;: &quot;DescribeInstances&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DescribeInstances</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The event source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ManagementEvent</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The timestamp when the event was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657247532000</para>
            /// </summary>
            [NameInMap("UsedTimestamp")]
            [Validation(Required=false)]
            public long? UsedTimestamp { get; set; }

        }

        /// <summary>
        /// <para>The token that determines the start point of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhY2NvdW50IjoiMTQyNDM3OTU4NjM4NzE2MSIsImV2ZW50SWQiOiI3MkJDRTExRi02OTU3LTQ0NUItQjY0MC1CNEUyMkM4NUEwQzgiLCJsb2dJZCI6IjgyLTE0MjQzNzk1ODYzODcxNjEiLCJ0aW1lIjoxNjAyMzExNTQwMD****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145318BE-DEE1-4C57-AA7C-5BE7D34A6AE0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
