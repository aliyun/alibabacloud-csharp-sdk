// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthConsumerResourceRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
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
        /// <para>The ID of the gateway authentication consumer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public long? ConsumerId { get; set; }

        /// <summary>
        /// <para>UpdateGatewayAuthConsumerResource</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-3f97e2989c344f35ab3fd62b19f1****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<UpdateGatewayAuthConsumerResourceRequestResourceList> ResourceList { get; set; }
        public class UpdateGatewayAuthConsumerResourceRequestResourceList : TeaModel {
            /// <summary>
            /// <para>The route ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7816</para>
            /// </summary>
            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public long? RouteId { get; set; }

            /// <summary>
            /// <para>The route name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>helo</para>
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

        }

    }

}
