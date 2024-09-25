// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <para>zh: Chinese en: English</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The type of the plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: custom</description></item>
        /// <item><description>1: permission authorization</description></item>
        /// <item><description>2: security protection</description></item>
        /// <item><description>3: transmission protocol</description></item>
        /// <item><description>4: traffic control</description></item>
        /// <item><description>5: traffic observation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOnly")]
        [Validation(Required=false)]
        public bool? EnableOnly { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-0adf3ad751284cc69fcf9669fba*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The name of the plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-auth</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
