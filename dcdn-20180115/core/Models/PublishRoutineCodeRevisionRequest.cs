// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PublishRoutineCodeRevisionRequest : TeaModel {
        /// <summary>
        /// <para>The environment to which you want to publish the code.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>production: the name of the environment, including the environment name (SpecName) and the domain name whitelist (AllowedHosts).</para>
        /// </description></item>
        /// <item><description><para>presetCanary: You can add canary release environments based on your business requirements. This parameter is optional.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;production&quot;,&quot;presetCanaryZhejiang&quot;]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, object> Envs { get; set; }

        /// <summary>
        /// <para>The name of the routine. The name must be unique among the routines that belong to the same Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the routine code that you want to publish.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1620876959997924701</para>
        /// </summary>
        [NameInMap("SelectCodeRevision")]
        [Validation(Required=false)]
        public string SelectCodeRevision { get; set; }

    }

}
