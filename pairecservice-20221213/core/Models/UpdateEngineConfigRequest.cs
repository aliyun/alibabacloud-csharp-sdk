// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateEngineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The content of the engine configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ListenConf&quot;: {
        ///         &quot;HttpAddr&quot;: &quot;&quot;,
        ///         &quot;HttpPort&quot;: 8000
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The environment.</para>
        /// <list type="bullet">
        /// <item><description><para>Daily: Daily environment.</para>
        /// </description></item>
        /// <item><description><para>Pre: Pre-production environment.</para>
        /// </description></item>
        /// <item><description><para>Prod: Production environment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pre</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID. To get the instance ID, see <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-***test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the engine configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>engine_config_v1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
