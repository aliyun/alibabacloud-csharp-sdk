// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerCreateSandboxInput : TeaModel {
        /// <summary>
        /// <para>Specifies whether the sandbox is allowed to access external networks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically pause after timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoPause")]
        [Validation(Required=false)]
        public bool? AutoPause { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically resume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoResume")]
        [Validation(Required=false)]
        public bool? AutoResume { get; set; }

        /// <summary>
        /// <para>The environment variable configuration.</para>
        /// </summary>
        [NameInMap("envVars")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvVars { get; set; }

        /// <summary>
        /// <para>The metadata configuration.</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public E2BNetwork Network { get; set; }

        /// <summary>
        /// <para>The runtime configuration.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public InnerSandboxRuntimeConfig Runtime { get; set; }

        /// <summary>
        /// <para>Specifies whether authentication is required to access the sandbox envd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("secure")]
        [Validation(Required=false)]
        public bool? Secure { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76eeecaa-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The unique identifier of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v9vjyzw64bsu83vw0dgs</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The volume mount configuration.</para>
        /// </summary>
        [NameInMap("volumeMounts")]
        [Validation(Required=false)]
        public InnerCreateSandboxVolumeMounts VolumeMounts { get; set; }

    }

}
