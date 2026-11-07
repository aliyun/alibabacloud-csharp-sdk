// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayAuthConsumerStatusRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
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
        /// <para>Specifies whether the authentication consumer is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConsumerStatus")]
        [Validation(Required=false)]
        public bool? ConsumerStatus { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-685f661467b54f48b7b7a76605ce****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the authentication consumer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
