// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InvokeDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization succeeded.  </description></item>
        /// <item><description>Other status codes indicate authorization failure. When authorization fails, check the <c>message</c> field for detailed error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public InvokeDiagnosisResponseBodyData Data { get; set; }
        public class InvokeDiagnosisResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Diagnostic task ID. You can use this ID to invoke the <c>GetDiagnosisResult</c> API to query the diagnosis result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ihqhAcrt</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>43A910E9-A739-525E-855D-A32C257F1826</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
