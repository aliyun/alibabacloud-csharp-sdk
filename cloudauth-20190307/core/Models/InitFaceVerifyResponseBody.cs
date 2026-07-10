// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitFaceVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public InitFaceVerifyResponseBodyResultObject ResultObject { get; set; }
        public class InitFaceVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The unique identifier for ID Verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91707dc296d469ad38e4c5efa6a0f24b</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>The URL for performing ID Verification in a web browser. After authentication is complete, the page redirects based on the ReturnUrl parameter.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The CertifyUrl returned by the initialization operation is <b>valid for 30 minutes and can be submitted for authentication only once</b>. Use it within the validity period and do not reuse it.</para>
            /// </description></item>
            /// <item><description><para>This parameter requires the <b>MetaInfo</b> parameter to be correctly passed in to return a CertifyUrl that matches the client. If the URL cannot be obtained, check whether <b>MetaInfo</b> and other input parameters are correct.</para>
            /// </description></item>
            /// <item><description><para>The domain name of this URL may change with service updates. To ensure normal service availability, do not apply access control to this domain name.</para>
            /// </description></item>
            /// <item><description><para>Do not use incognito mode or modify the URL during browser redirection. Otherwise, a <b>signature exception</b> error may occur.</para>
            /// </description></item>
            /// </list>
            /// <para>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://t.aliyun.com/">https://t.aliyun.com/</a>****</para>
            /// </summary>
            [NameInMap("CertifyUrl")]
            [Validation(Required=false)]
            public string CertifyUrl { get; set; }

        }

    }

}
