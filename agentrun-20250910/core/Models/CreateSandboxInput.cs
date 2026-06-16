// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateSandboxInput : TeaModel {
        /// <summary>
        /// <para>The NAS configuration.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The OSS mount configuration.</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The PolarFS configuration.</para>
        /// </summary>
        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

        /// <summary>
        /// <para>The unique identifier of the sandbox instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01KE8DAJ35JC8SKP9CNFRZ8CW7</para>
        /// </summary>
        [NameInMap("sandboxId")]
        [Validation(Required=false)]
        public string SandboxId { get; set; }

        /// <summary>
        /// <para>The idle timeout for the sandbox, in seconds.</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public int? SandboxIdleTimeoutInSeconds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The idle timeout for the sandbox, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sandboxIdleTimeoutSeconds")]
        [Validation(Required=false)]
        [Obsolete]
        public int? SandboxIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>templateName</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
