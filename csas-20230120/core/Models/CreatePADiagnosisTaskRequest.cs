// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreatePADiagnosisTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the terminal device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2987b3e0-8108-2f99-4d18-3b4f1c1c36d7</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>The diagnosis type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullLink</b>: full-link diagnosis.</description></item>
        /// <item><description><b>Application</b>: application diagnosis.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FullLink</para>
        /// </summary>
        [NameInMap("DiagnoseType")]
        [Validation(Required=false)]
        public string DiagnoseType { get; set; }

        /// <summary>
        /// <para>The address to diagnose.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>socialapp-gateway.client9.me</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The POP point ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pop-3e244b62357dcafc</para>
        /// </summary>
        [NameInMap("PopId")]
        [Validation(Required=false)]
        public string PopId { get; set; }

        /// <summary>
        /// <para>The POP point selection mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AutoSelect</b>: automatic selection.</description></item>
        /// <item><description><b>ManualSelect</b>: manual selection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManualSelect</para>
        /// </summary>
        [NameInMap("PopMode")]
        [Validation(Required=false)]
        public string PopMode { get; set; }

        /// <summary>
        /// <para>The port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The protocol used by the internal network access application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The extra configurations for UDP diagnosis. If this parameter is not specified, any response received is considered a success.</para>
        /// </summary>
        [NameInMap("UdpExtraConfigs")]
        [Validation(Required=false)]
        public CreatePADiagnosisTaskRequestUdpExtraConfigs UdpExtraConfigs { get; set; }
        public class CreatePADiagnosisTaskRequestUdpExtraConfigs : TeaModel {
            /// <summary>
            /// <para>The expected response from the backend server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("ExpectedResponse")]
            [Validation(Required=false)]
            public string ExpectedResponse { get; set; }

            /// <summary>
            /// <para>The UDP request content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("RequestContent")]
            [Validation(Required=false)]
            public string RequestContent { get; set; }

        }

        /// <summary>
        /// <para>The user group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户组ID。</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhaosi</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
