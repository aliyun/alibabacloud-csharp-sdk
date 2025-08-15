// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned Alibaba Cloud services.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<GetAccessKeyLastUsedProductsResponseBodyProducts> Products { get; set; }
        public class GetAccessKeyLastUsedProductsResponseBodyProducts : TeaModel {
            /// <summary>
            /// <para>The event details.</para>
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
            /// <para>The Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The Chinese name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service (ECS)</para>
            /// </summary>
            [NameInMap("ServiceNameCn")]
            [Validation(Required=false)]
            public string ServiceNameCn { get; set; }

            /// <summary>
            /// <para>The English name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
            /// </summary>
            [NameInMap("ServiceNameEn")]
            [Validation(Required=false)]
            public string ServiceNameEn { get; set; }

            /// <summary>
            /// <para>The event source.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Internal</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>other events</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ManagementEvent</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>management events</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>DataEvent</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>data events</para>
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagementEvent</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Unit: millisecond.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657247532000</para>
            /// </summary>
            [NameInMap("UsedTimestamp")]
            [Validation(Required=false)]
            public long? UsedTimestamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
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
