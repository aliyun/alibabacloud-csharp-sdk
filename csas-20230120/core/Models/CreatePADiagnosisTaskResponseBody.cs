// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreatePADiagnosisTaskResponseBody : TeaModel {
        [NameInMap("DiagnosisTask")]
        [Validation(Required=false)]
        public CreatePADiagnosisTaskResponseBodyDiagnosisTask DiagnosisTask { get; set; }
        public class CreatePADiagnosisTaskResponseBodyDiagnosisTask : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>E9EE1CE7-4AA0-521D-B8E1-E13E47F05E94</para>
            /// </summary>
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>diag-3e0d36d6c15a0502</para>
            /// </summary>
            [NameInMap("DiagnoseId")]
            [Validation(Required=false)]
            public string DiagnoseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FullLink</para>
            /// </summary>
            [NameInMap("DiagnoseType")]
            [Validation(Required=false)]
            public string DiagnoseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.16.6.1</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pop-8ded63ce9d3d317e</para>
            /// </summary>
            [NameInMap("PopId")]
            [Validation(Required=false)]
            public string PopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AutoSelect</para>
            /// </summary>
            [NameInMap("PopMode")]
            [Validation(Required=false)]
            public string PopMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UdpExtraConfigs")]
            [Validation(Required=false)]
            public CreatePADiagnosisTaskResponseBodyDiagnosisTaskUdpExtraConfigs UdpExtraConfigs { get; set; }
            public class CreatePADiagnosisTaskResponseBodyDiagnosisTaskUdpExtraConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("ExpectedResponse")]
                [Validation(Required=false)]
                public string ExpectedResponse { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("RequestContent")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

            }

            [NameInMap("UserGroup")]
            [Validation(Required=false)]
            public CreatePADiagnosisTaskResponseBodyDiagnosisTaskUserGroup UserGroup { get; set; }
            public class CreatePADiagnosisTaskResponseBodyDiagnosisTaskUserGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ug-xxxxxxxx</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IT</para>
                /// </summary>
                [NameInMap("UserGroupName")]
                [Validation(Required=false)]
                public string UserGroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F79AE39-6622-5292-87EF-DE45631DE4D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
