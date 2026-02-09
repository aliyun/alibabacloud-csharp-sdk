// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ContainerSpec : TeaModel {
        /// <summary>
        /// <para>The command parameters.</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// <para>The user command.</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The environment variables.</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public List<EnvVar> Env { get; set; }

        /// <summary>
        /// <para>The endpoint of the container image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/pai-dlc/curl:v1.0.0</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The name of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data-init</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The container resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ResourceRequirements Resources { get; set; }

        /// <summary>
        /// <para>The working directory in the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
