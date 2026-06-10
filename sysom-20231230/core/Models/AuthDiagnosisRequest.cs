// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class AuthDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>Automatic creation of role</para>
        /// </summary>
        [NameInMap("autoCreateRole")]
        [Validation(Required=false)]
        public bool? AutoCreateRole { get; set; }

        /// <summary>
        /// <para>Automatic installation of agent</para>
        /// </summary>
        [NameInMap("autoInstallAgent")]
        [Validation(Required=false)]
        public bool? AutoInstallAgent { get; set; }

        /// <summary>
        /// <para>List of instances to authorize for diagnosis</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<AuthDiagnosisRequestInstances> Instances { get; set; }
        public class AuthDiagnosisRequestInstances : TeaModel {
            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9b9vucz1iubsz8sjqo</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
