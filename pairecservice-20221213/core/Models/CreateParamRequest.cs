// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateParamRequest : TeaModel {
        /// <summary>
        /// <para>The environment to which the parameter belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: daily environment.</description></item>
        /// <item><description>Pre: staging environment.</description></item>
        /// <item><description>Prod: production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the ListInstances operation to obtain the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-abcdefg1234</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The parameter name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>home</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The scene ID. You can call the ListScenes operation to obtain the scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Normal: common parameter.</para>
        /// </description></item>
        /// <item><description><para>Encryption: encrypted parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>house</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
