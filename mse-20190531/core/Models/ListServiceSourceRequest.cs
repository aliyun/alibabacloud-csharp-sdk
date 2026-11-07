// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListServiceSourceRequest : TeaModel {
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
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-c51a15c7ee934a4fb945ccf35fe1****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>Specifies the service source type. If this parameter is left empty, all types are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>K8s: Container Service.</description></item>
        /// <item><description>MSE: MSE Nacos.</description></item>
        /// <item><description>MSE_ZK: MSE ZooKeeper.</description></item>
        /// <item><description>SAE: SAE registry.</description></item>
        /// <item><description>EDAS: EDAS registry.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
