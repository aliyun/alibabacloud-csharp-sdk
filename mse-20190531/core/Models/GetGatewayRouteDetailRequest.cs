// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayRouteDetailRequest : TeaModel {
        /// <summary>
        /// <para>Language type of the returned information:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Gateway unique identifier ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-5d3a78a53ec947aa928212d671d400ac</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>Route ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1050</para>
        /// </summary>
        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public long? RouteId { get; set; }

    }

}
