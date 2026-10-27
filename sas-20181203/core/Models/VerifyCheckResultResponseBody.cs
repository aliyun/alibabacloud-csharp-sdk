// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifyCheckResultResponseBodyData Data { get; set; }
        public class VerifyCheckResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The operation code of the cloud service configuration check task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Throttling</b>: Throttling.</description></item>
            /// <item><description><b>ActionTrailUnauthorized</b>: Unauthorized error.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Throttling</para>
            /// </summary>
            [NameInMap("OperateCode")]
            [Validation(Required=false)]
            public string OperateCode { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8eded533-5348-468c-aa1d-0aa2934a7***</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The duration of the throttling. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("ThrottlingTimeSecond")]
            [Validation(Required=false)]
            public int? ThrottlingTimeSecond { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C0A3FA0-AA32-5660-8989-85A5582F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
