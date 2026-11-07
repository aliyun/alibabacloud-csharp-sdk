// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreatePluginConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the response is displayed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese. This is the default value.</description></item>
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
        /// <para>The plug-in configuration. The configuration content of a Wasm plug-in is in YAML format, and the configuration content of a Lua plug-in is Lua code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name: John
        /// age: 18
        /// friends:</para>
        /// <list type="bullet">
        /// <item><description>David</description></item>
        /// <item><description>Anne</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The application scope of the plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Global.</description></item>
        /// <item><description>1: Route.</description></item>
        /// <item><description>2: Domain name.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the plug-in.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-ubuwqygbq4783gqb2y3f87q****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway plug-in.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public long? PluginId { get; set; }

        /// <summary>
        /// <para>The list of domain name IDs or route IDs. The specific type depends on the value of ConfigLevel.</para>
        /// </summary>
        [NameInMap("ResourceIdList")]
        [Validation(Required=false)]
        public string ResourceIdListShrink { get; set; }

    }

}
