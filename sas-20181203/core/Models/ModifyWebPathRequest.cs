// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebPathRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the web directory. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>webPathType</b>: the type of the web directory</description></item>
        /// <item><description><b>webPath</b>: the web directory</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;webPathType&quot;: &quot;customize&quot;,
        ///       &quot;webPath&quot;: &quot;/root/www****&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The protected asset to which the web directory belongs. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>target</b>: the protected asset.</description></item>
        /// <item><description><b>targetType</b>: the type of the asset. Set the value to uuid.</description></item>
        /// <item><description><b>flag</b>: the type of the operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;target&quot;:&quot;0186127a-d33e-4d0c-94fb-8f25f87bc69f&quot;,&quot;targetType&quot;:&quot;uuid&quot;,&quot;flag&quot;:&quot;add&quot;}]</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The type of the configuration item. Set the value to <b>web_path</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web_path</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
