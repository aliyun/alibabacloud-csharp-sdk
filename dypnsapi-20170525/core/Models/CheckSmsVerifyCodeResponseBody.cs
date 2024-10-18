// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CheckSmsVerifyCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>For more information about other error codes, see <a href="https://help.aliyun.com/zh/pnvs/developer-reference/api-return-code?spm=a2c4g.11174283.0.0.70c5616bkj38Wa">Response codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public CheckSmsVerifyCodeResponseBodyModel Model { get; set; }
        public class CheckSmsVerifyCodeResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>The external ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1212312</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>The verification results. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PASS: The verification is successful.</description></item>
            /// <item><description>UNKNOWN: The verification failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASS</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
