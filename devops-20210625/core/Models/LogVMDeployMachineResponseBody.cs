// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class LogVMDeployMachineResponseBody : TeaModel {
        [NameInMap("deployMachineLog")]
        [Validation(Required=false)]
        public LogVMDeployMachineResponseBodyDeployMachineLog DeployMachineLog { get; set; }
        public class LogVMDeployMachineResponseBodyDeployMachineLog : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("aliyunRegion")]
            [Validation(Required=false)]
            public string AliyunRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111111111</para>
            /// </summary>
            [NameInMap("deployBeginTime")]
            [Validation(Required=false)]
            public long? DeployBeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12222222</para>
            /// </summary>
            [NameInMap("deployEndTime")]
            [Validation(Required=false)]
            public long? DeployEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("deployLog")]
            [Validation(Required=false)]
            public string DeployLog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/tmp/log</para>
            /// </summary>
            [NameInMap("deployLogPath")]
            [Validation(Required=false)]
            public string DeployLogPath { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true 接口调用成功，false 接口调用失败</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
