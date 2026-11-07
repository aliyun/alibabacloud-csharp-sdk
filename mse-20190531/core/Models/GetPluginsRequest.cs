// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetPluginsRequest : TeaModel {
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
        /// <para>The plug-in type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Custom.</description></item>
        /// <item><description>1: Authentication and authorization.</description></item>
        /// <item><description>2: Security protection.</description></item>
        /// <item><description>3: Transport protocol.</description></item>
        /// <item><description>4: Traffic control.</description></item>
        /// <item><description>5: Traffic observability.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// <para>Specifies whether the plug-in is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOnly")]
        [Validation(Required=false)]
        public bool? EnableOnly { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
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
