// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The sorting order. This parameter is currently not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DescSort")]
        [Validation(Required=false)]
        public bool? DescSort { get; set; }

        /// <summary>
        /// <para>The filter parameters.</para>
        /// </summary>
        [NameInMap("FilterParams")]
        [Validation(Required=false)]
        public ListGatewayRequestFilterParams FilterParams { get; set; }
        public class ListGatewayRequestFilterParams : TeaModel {
            /// <summary>
            /// <para>The gateway type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ingress</para>
            /// </summary>
            [NameInMap("GatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

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
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse_ingresspre-cn-****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;key&quot;:&quot;tagkey&quot;,&quot;value&quot;:&quot;tagvalue&quot;}]</para>
            /// </summary>
            [NameInMap("MseTag")]
            [Validation(Required=false)]
            public string MseTag { get; set; }

            /// <summary>
            /// <para>The gateway name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rutain-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-7y2uye*****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp13hhyjntbab7w****</para>
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public string Vpc { get; set; }

        }

        /// <summary>
        /// <para>The order information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
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
        /// <para>The number of instances per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
