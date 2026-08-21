// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class AuthDiagnosisRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic creation of the service-linked role.</para>
        /// </summary>
        [NameInMap("autoCreateRole")]
        [Validation(Required=false)]
        public bool? AutoCreateRole { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically install the latest version of the agent if it is not installed.</para>
        /// </summary>
        [NameInMap("autoInstallAgent")]
        [Validation(Required=false)]
        public bool? AutoInstallAgent { get; set; }

        /// <summary>
        /// <para>The list of instances authorized for diagnosis.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<AuthDiagnosisRequestInstances> Instances { get; set; }
        public class AuthDiagnosisRequestInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9b9vucz1iubsz8sjqo</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
