// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateEngineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The content of the engine config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Daily</c>: The daily environment.</para>
        /// </description></item>
        /// <item><description><para><c>Pre</c>: The pre-production environment.</para>
        /// </description></item>
        /// <item><description><para><c>Prod</c>: The production environment.</para>
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
        /// <para>The ID of the instance. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-***test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the engine config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>engine_config_v1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
