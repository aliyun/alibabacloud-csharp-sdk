// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdatePluginConfigShrinkRequest : TeaModel {
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

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The application scope of the plug-in.</para>
        /// <list type="bullet">
        /// <item><description>0: global</description></item>
        /// <item><description>1: route</description></item>
        /// <item><description>2: domain name</description></item>
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

        [NameInMap("ResourceIdList")]
        [Validation(Required=false)]
        public string ResourceIdListShrink { get; set; }

    }

}
