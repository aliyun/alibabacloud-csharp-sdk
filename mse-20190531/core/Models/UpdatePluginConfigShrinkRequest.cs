// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdatePluginConfigShrinkRequest : TeaModel {
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
        /// <para>The configuration content of the plug-in. Use YAML for Wasm plug-ins and Lua code for Lua plug-ins.</para>
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
        /// <item><description><para>0: Global.</para>
        /// </description></item>
        /// <item><description><para>1: Route.</para>
        /// </description></item>
        /// <item><description><para>2: Domain name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-ubuwqygbq4783gqb2y3f87q****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1667309705000</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        [Obsolete]
        public string GmtCreate { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1667309705000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        [Obsolete]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the plug-in configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the gateway plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public long? PluginId { get; set; }

        /// <summary>
        /// <para>The list of domain name IDs or route IDs, which depends on the value of ConfigLevel.</para>
        /// </summary>
        [NameInMap("ResourceIdList")]
        [Validation(Required=false)]
        public string ResourceIdListShrink { get; set; }

    }

}
