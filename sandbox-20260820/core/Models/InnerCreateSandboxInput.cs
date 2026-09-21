// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerCreateSandboxInput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoPause")]
        [Validation(Required=false)]
        public bool? AutoPause { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoResume")]
        [Validation(Required=false)]
        public bool? AutoResume { get; set; }

        [NameInMap("envVars")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvVars { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public E2BNetwork Network { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public InnerSandboxRuntimeConfig Runtime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("secure")]
        [Validation(Required=false)]
        public bool? Secure { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76eeecaa-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v9vjyzw64bsu83vw0dgs</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("volumeMounts")]
        [Validation(Required=false)]
        public InnerCreateSandboxVolumeMounts VolumeMounts { get; set; }

    }

}
