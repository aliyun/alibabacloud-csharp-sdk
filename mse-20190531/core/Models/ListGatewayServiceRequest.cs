// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayServiceRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DescSort")]
        [Validation(Required=false)]
        public bool? DescSort { get; set; }

        /// <summary>
        /// <para>The filter conditions in the format of {&quot;key1&quot;:&quot;value1&quot;}.</para>
        /// </summary>
        [NameInMap("FilterParams")]
        [Validation(Required=false)]
        public ListGatewayServiceRequestFilterParams FilterParams { get; set; }
        public class ListGatewayServiceRequestFilterParams : TeaModel {
            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-5017305290e14centbrveca****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The Terms of Service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HTTP</description></item>
            /// <item><description>HTTPS</description></item>
            /// <item><description>HTTP2</description></item>
            /// <item><description>GRPC</description></item>
            /// <item><description>DUBBO</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// <para>The source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MSE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The sort attribute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreate</para>
        /// </summary>
        [NameInMap("OrderItem")]
        [Validation(Required=false)]
        public string OrderItem { get; set; }

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
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
