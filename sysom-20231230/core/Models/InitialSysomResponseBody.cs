// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InitialSysomResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FCA2E38-2A8E-5501-93BD-5CE1BA58F2EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization succeeded.  </description></item>
        /// <item><description>Any other status code indicates a failed authorization. In such cases, view the <c>message</c> field for detailed error information.</description></item>
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
        public InitialSysomResponseBodyData Data { get; set; }
        public class InitialSysomResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service role exists</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("role_exist")]
            [Validation(Required=false)]
            public bool? RoleExist { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIException: SysomOpenAPI.InvalidParameter Invalid params, should be json string or dict</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
