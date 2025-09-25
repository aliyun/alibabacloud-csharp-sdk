// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitFaceVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates success, other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public InitFaceVerifyResponseBodyResultObject ResultObject { get; set; }
        public class InitFaceVerifyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Unique identifier for real-person authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91707dc296d469ad38e4c5efa6a0f24b</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>URL for real-person authentication in a Web browser, which will redirect according to the ReturnUrl parameter after authentication.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The CertifyUrl returned by the initialization interface is valid for <b>30 minutes and can only be used once</b>. Please use it within the validity period to avoid reuse.</para>
            /// </description></item>
            /// <item><description><para>This parameter requires the correct input of <b>MetaInfo</b> to return a CertifyUrl that matches the client. If you cannot obtain it, please check whether <b>MetaInfo</b> and other input parameters are correct.</para>
            /// </description></item>
            /// <item><description><para>The domain name of this URL may change with service updates. To ensure normal service availability, it is recommended not to apply access control to this domain name.</para>
            /// </description></item>
            /// <item><description><para>When redirecting in the browser, try not to use incognito mode or modify the URL, as this may result in a <b>signature error</b>.</para>
            /// </description></item>
            /// </list>
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
